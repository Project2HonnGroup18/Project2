using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

public class BorrowTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private System.Func<int, string> UserGetPublicationPath = (userId) => "/api/users/" + userId + "/publications";
    private System.Func<int, int, string> UserGetSpecificPublicationPath = (userId, publicationId) => "/api/users/" + userId + "/publications/" + publicationId;
    private readonly HttpClient _client;
    private CustomWebApplicationFactory<Startup> _factory;
    public class PubComparer: IEqualityComparer<Publication>
    {
        public bool Equals(Publication x, Publication y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Publication x)
        {
            return x.Id;
        }
    }

    public BorrowTests(CustomWebApplicationFactory<Startup> factory)
    {
        _factory = factory;
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task FriendCanGetpublications()
    {
        //User 85 has 3 publications loaned 
        int userId = 85;
        string borrowString = UserGetPublicationPath(userId);
        
        // Get all borrows, check if new publication is in the list
        var httpResponse = await _client.GetAsync(borrowString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var pubList = JsonConvert.DeserializeObject<IEnumerable<Publication>>(stringResponse);
        Assert.NotEmpty(pubList);
    }

    [Fact]
    public async Task FriendCannotBorrowTwice()
    {
        _client.DefaultRequestHeaders.Add("Role", "auth");

        int userId = 5;
        int publicationId = 100;
        PublicationToFriendInputModel p2fInput = new PublicationToFriendInputModel();
        
        // Borrow a publication
        var httpResponse = await _client.PostAsJsonAsync(UserGetSpecificPublicationPath(userId, publicationId), p2fInput);
        httpResponse.EnsureSuccessStatusCode();

        var httpResponse2 = await _client.PostAsJsonAsync(UserGetSpecificPublicationPath(userId, publicationId), p2fInput);
        Assert.Equal(httpResponse2.StatusCode, System.Net.HttpStatusCode.Conflict);
    }

    [Fact]
    public async Task FriendCanBorrowPublication()
    {
        _client.DefaultRequestHeaders.Add("Role", "auth");

        int userId = 50;
        int publicationId = 31;

        PublicationToFriendInputModel borrowModel = new PublicationToFriendInputModel();
        borrowModel.BorrowDate = new System.DateTime(2018, 1, 20);
        borrowModel.ReturnDate = new System.DateTime(2018, 3, 20);
        
        // The endpoint or route of the controller action.
        var addLoan = await _client.PostAsJsonAsync(UserGetSpecificPublicationPath(userId, publicationId), borrowModel);
        // Must be successful.
        addLoan.EnsureSuccessStatusCode();
        await addLoan.Content.ReadAsStringAsync();
        
        // Get all borrows, check if new publication is in the list
        var httpResponse = await _client.GetAsync(UserGetPublicationPath(userId));
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var pubList = JsonConvert.DeserializeObject<IEnumerable<Publication>>(stringResponse);
        Assert.Contains(new Publication{Id = publicationId}, pubList, new PubComparer());
    }

    
    [Fact]
    public async Task FriendCanRemovePublication()
    {
        _client.DefaultRequestHeaders.Add("Role", "auth");

        int userId = 52;
        int publicationId = 366;

        // The endpoint or route of the controller action.
        var addLoan = await _client.DeleteAsync(UserGetSpecificPublicationPath(userId, publicationId));
        // Must be successful.
        addLoan.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task FriendCanUpdatePublication()
    {
        _client.DefaultRequestHeaders.Add("Role", "auth");

        int userId = 52;
        int publicationId = 366;
        
        PublicationToFriendInputModel borrowModel = new PublicationToFriendInputModel{
                                                        BorrowDate = new System.DateTime(2018, 1, 20)
                                                    };

        // The endpoint or route of the controller action.
        var putLoan = await _client.PutAsJsonAsync(UserGetSpecificPublicationPath(userId, publicationId), borrowModel);
        // Must be successful.
        putLoan.EnsureSuccessStatusCode();
    }
}