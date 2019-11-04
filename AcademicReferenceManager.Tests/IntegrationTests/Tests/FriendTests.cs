using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Dtos;
using System.Linq;

public class FriendTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private string basePath = "/api/users/";
    private System.Func<int, string> GetUserPath;
    private System.Func<int, string> GetRecommendedPath;
    private string authenticationName = "Role";
    private string authenticationValue = "admin";
    private readonly HttpClient _client;
    
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
    public FriendTests(CustomWebApplicationFactory<Startup> factory)
    {
        GetUserPath = (userId) => basePath + userId;
        GetRecommendedPath = (userId) => basePath + userId + "/recommendations";
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CanGetFriend()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        int userId = 1;
        string userPath = GetUserPath(userId);

        // The endpoint or route of the controller action.
        var httpResponse = await _client.GetAsync(userPath);

        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();

        // Deserialize and examine results.
        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var friend = JsonConvert.DeserializeObject<FriendDto>(stringResponse);
        Assert.Equal(1, friend.Id);
    }

    [Fact]
    public async Task FriendWithIdOfNegativeOneWillThrowException()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        int userId = -1;
        string userPath = GetUserPath(userId);
        
        var httpResponse = await _client.GetAsync(userPath);
        Assert.Equal(System.Net.HttpStatusCode.NotFound, httpResponse.StatusCode);
    }

    [Fact]
    public async Task CanCreateFriend()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        var newFriend = new FriendInputModel();
        newFriend.FirstName = "Arius";
        newFriend.Email = "arius@bland.is";
        
        // The endpoint or route of the controller action.
        var httpResponse = await _client.PostAsJsonAsync(basePath, newFriend);

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        
        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();
    }
    [Fact]
    public async Task RecommendationDoesNotContainBorrowed()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 100;
        int publicationId = 64;
        string recPath = GetRecommendedPath(userId);

        var httpGet = await _client.GetAsync(recPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var recommendations = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(responseText);
        Assert.DoesNotContain(new PublicationDto{Id = publicationId}, recommendations, new PubComparer());
    }

    [Fact]
    public async Task RecommendationsAreInSortedOrder()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        int userId = 90;
        string recPath = GetRecommendedPath(userId);

        var httpGet = await _client.GetAsync(recPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        
        // This list should come out sorted
        var recommendations = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(responseText).Select(r => r.Rating);
        
        // Sort the list we got and compare
        var sortedRecs = recommendations.OrderByDescending(r => r).ToList();
        Assert.Equal(sortedRecs, recommendations);
    }
}