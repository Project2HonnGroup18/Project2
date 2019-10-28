using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

public class BorrowControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    public class Pub2FriendComparer: IEqualityComparer<PublicationToFriendInputModel>
    {
        public bool Equals(PublicationToFriendInputModel x, PublicationToFriendInputModel y)
        {
            return x.FriendId == y.FriendId && x.PublicationId == y.PublicationId;
        }

        public int GetHashCode(PublicationToFriendInputModel x)
        {
            return x.FriendId ^ x.PublicationId;
        }
    }

    public BorrowControllerTests(CustomWebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task FriendCanBorrowPublication()
    {
        PublicationToFriendInputModel borrowModel = new PublicationToFriendInputModel();
        borrowModel.BorrowDate = new System.DateTime(2018, 1, 20);
        borrowModel.ReturnDate = new System.DateTime(2018, 3, 20);
        borrowModel.FriendId = 1;
        borrowModel.PublicationId = 10;

        // The endpoint or route of the controller action.
        var addLoan = await _client.PostAsJsonAsync("/api/borrow", borrowModel);

        
        // Must be successful.
        addLoan.EnsureSuccessStatusCode();

        // Wait for the request to finish.
        await addLoan.Content.ReadAsStringAsync();
        
        // Get all publication loans
        var httpResponse = await _client.GetAsync("/api/borrow");

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var loans = JsonConvert.DeserializeObject<IEnumerable<PublicationToFriendInputModel>>(stringResponse);
        Assert.Contains(borrowModel, loans, new Pub2FriendComparer());
    }
}