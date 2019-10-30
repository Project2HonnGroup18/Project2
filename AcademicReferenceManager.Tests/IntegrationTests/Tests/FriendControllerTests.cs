using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

public class FriendControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public FriendControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CanGetFriend()
    {
        // The endpoint or route of the controller action.
        var httpResponse = await _client.GetAsync("/api/friend/1");

        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();

        // Deserialize and examine results.
        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var friend = JsonConvert.DeserializeObject<Friend>(stringResponse);
        System.Console.WriteLine(friend.LastName);
        Assert.True(friend.FirstName == "Con");
    }

    [Fact]
    public async Task CanCreateFriend()
    {
        var newFriend = new FriendInputModel();
        newFriend.FirstName = "Arius";
        newFriend.Email = "arius@bland.is";
        
        // The endpoint or route of the controller action.
        var httpResponse = await _client.PostAsJsonAsync("/api/friend", newFriend);

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        
        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();
    }
}