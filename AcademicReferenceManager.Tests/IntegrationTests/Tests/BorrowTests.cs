using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Dtos;
using System;

public class BorrowTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private string basePath = "/api/users/";
    private Func<int, string> UserPublicationPath;
    private Func<int, int, string> SpecificUserPublicationPath;
    private string authenticationName = "Role";
    private string authenticationValue = "auth";

    private readonly HttpClient _client;
    private CustomWebApplicationFactory<Startup> _factory;
    public class PubComparer: IEqualityComparer<PublicationDto>
    {
        public bool Equals(PublicationDto x, PublicationDto y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(PublicationDto x)
        {
            return x.Id;
        }
    }

    public BorrowTests(CustomWebApplicationFactory<Startup> factory)
    {
        UserPublicationPath = (userId) => basePath + userId + "/publications";
        SpecificUserPublicationPath = (userId, publicationId) => basePath + userId + "/publications/" + publicationId;

        _factory = factory;
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task FriendCanGetpublications()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        //User 85 has 3 publications loaned 
        int userId = 85;
        string borrowString = UserPublicationPath(userId);
        
        // Get all borrows, check if new publication is in the list
        var httpResponse = await _client.GetAsync(borrowString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var pubList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.NotEmpty(pubList);
    }

    [Fact]
    public async Task FriendCannotBorrowTwice()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        int userId = 5;
        int publicationId = 100;
        PublicationToFriendInputModel p2fInput = new PublicationToFriendInputModel();
        
        // Borrow a publication
        var httpResponse = await _client.PostAsJsonAsync(SpecificUserPublicationPath(userId, publicationId), p2fInput);
        httpResponse.EnsureSuccessStatusCode();

        var httpResponse2 = await _client.PostAsJsonAsync(SpecificUserPublicationPath(userId, publicationId), p2fInput);
        Assert.Equal(System.Net.HttpStatusCode.PreconditionFailed, httpResponse2.StatusCode);
    }

    [Fact]
    public async Task FriendCanBorrowPublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        int userId = 50;
        int publicationId = 31;

        PublicationToFriendInputModel borrowModel = new PublicationToFriendInputModel();
        borrowModel.BorrowDate = new System.DateTime(2018, 1, 20);
        borrowModel.ReturnDate = new System.DateTime(2018, 3, 20);
        
        // The endpoint or route of the controller action.
        var addLoan = await _client.PostAsJsonAsync(SpecificUserPublicationPath(userId, publicationId), borrowModel);
        // Must be successful.
        addLoan.EnsureSuccessStatusCode();
        await addLoan.Content.ReadAsStringAsync();
        
        // Get all borrows, check if new publication is in the list
        var httpResponse = await _client.GetAsync(UserPublicationPath(userId));
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var pubList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.Contains(new PublicationDto{Id = publicationId}, pubList, new PubComparer());
    }

    
    [Fact]
    public async Task FriendCanRemovePublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        int userId = 52;
        int publicationId = 366;

        // The endpoint or route of the controller action.
        var addLoan = await _client.DeleteAsync(SpecificUserPublicationPath(userId, publicationId));
        // Must be successful.
        addLoan.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task FriendCanUpdatePublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        int userId = 52;
        int publicationId = 366;
        
        PublicationToFriendInputModel borrowModel = new PublicationToFriendInputModel{
                                                        BorrowDate = new System.DateTime(2018, 1, 20)
                                                    };

        // The endpoint or route of the controller action.
        var putLoan = await _client.PutAsJsonAsync(SpecificUserPublicationPath(userId, publicationId), borrowModel);
        // Must be successful.
        putLoan.EnsureSuccessStatusCode();
    }
}