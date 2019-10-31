using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Dtos;

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
        var httpResponse = await _client.GetAsync("/api/users/1");

        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();

        // Deserialize and examine results.
        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var friend = JsonConvert.DeserializeObject<FriendDto>(stringResponse);
        Assert.True(friend.FirstName == "Con");
    }

    [Fact]
    public async Task CanCreateFriend()
    {
        var newFriend = new FriendInputModel();
        newFriend.FirstName = "Arius";
        newFriend.Email = "arius@bland.is";
        
        // The endpoint or route of the controller action.
        var httpResponse = await _client.PostAsJsonAsync("/api/users", newFriend);

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        
        // Must be successful.
        httpResponse.EnsureSuccessStatusCode();
    }
}