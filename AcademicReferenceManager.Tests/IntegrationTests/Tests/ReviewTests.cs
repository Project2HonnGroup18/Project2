using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using AcademicReferenceManager.WebApi;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Dtos;
using System;

public class ReviewTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private string userBasePath = "/api/users/";
    private Func<string, int, string> GetReviewPath;
    private Func<string, int, int, string> GetSpecificReviewPath;

    
    private string authenticationName = "Authorization";
    private string authenticationValue = "admin";

    private readonly HttpClient _client;

    public ReviewTests(CustomWebApplicationFactory<Startup> factory)
    {
        GetReviewPath = (firstPath, firstId) => firstPath + firstId + "/reviews";
        GetSpecificReviewPath = (firstPath, firstId, secondId) => firstPath + firstId + "/reviews/" + secondId;
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CanCreateReview()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 100;
        int publicationId = 64;
        int rating = 2;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);
        ReviewInputModel reviewInput = new ReviewInputModel{Rating = rating};

        var httpPost = await _client.PostAsJsonAsync(reviewPath, reviewInput);
        httpPost.EnsureSuccessStatusCode();
    }

    [Fact]
    public async Task CantReviewNonBorrowedPublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 5;
        int publicationId = 5;
        int rating = 2;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);
        ReviewInputModel reviewInput = new ReviewInputModel{Rating = rating};

        var httpPost = await _client.PostAsJsonAsync(reviewPath, reviewInput);
        Assert.Equal(System.Net.HttpStatusCode.Conflict, httpPost.StatusCode);
    }

    [Fact]
    public async Task CanGetReviewsFromFriend()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 100;
        string reviewPath = GetReviewPath(userBasePath, userId);

        var httpGet = await _client.GetAsync(reviewPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var reviews = JsonConvert.DeserializeObject<IEnumerable<ReviewDto>>(responseText);
        Assert.NotEmpty(reviews);
    }

    [Fact]
    public async Task CanGetReviewFromFriend()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 90;
        int publicationId = 725;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);

        var httpGet = await _client.GetAsync(reviewPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var reviews = JsonConvert.DeserializeObject<ReviewDto>(responseText);
        Assert.Equal(userId, reviews.FriendId);
    }

    [Fact]
    public async Task CanUpdateReviewFromFriend()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 86;
        int publicationId = 462;
        int rating = 4;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);
        ReviewInputModel reviewInput = new ReviewInputModel{Rating = rating};

        var httpPut = await _client.PutAsJsonAsync(reviewPath, reviewInput);
        httpPut.EnsureSuccessStatusCode();

        string responseText = await httpPut.Content.ReadAsStringAsync();
        var review = JsonConvert.DeserializeObject<ReviewDto>(responseText);
        Assert.Equal(review.Rating, rating);
    }

    [Fact]
    public async Task CantUpdateNonexistentReview()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 69;
        int publicationId = 666;
        int rating = 4;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);
        ReviewInputModel reviewInput = new ReviewInputModel{Rating = rating};

        var httpPut = await _client.PutAsJsonAsync(reviewPath, reviewInput);
        Assert.Equal(System.Net.HttpStatusCode.NotFound, httpPut.StatusCode);
    }

    [Fact]
    public async Task CanGetReviewsFromPublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 81;
        string reviewPath = GetReviewPath(userBasePath, userId);

        var httpGet = await _client.GetAsync(reviewPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var reviews = JsonConvert.DeserializeObject<IEnumerable<ReviewDto>>(responseText);
        Assert.NotEmpty(reviews);
    }

    [Fact]
    public async Task CanGetReviewFromPublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 66;
        int publicationId = 13;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);

        var httpGet = await _client.GetAsync(reviewPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var reviews = JsonConvert.DeserializeObject<ReviewDto>(responseText);
        Assert.Equal(userId, reviews.FriendId);
    }

    
    [Fact]
    public async Task CanDeleteReviewFromPublication()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        
        // The database is previously seeded with this loan
        int userId = 72;
        int publicationId = 838;
        string reviewPath = GetSpecificReviewPath(userBasePath, userId, publicationId);

        var httpGet = await _client.DeleteAsync(reviewPath);
        httpGet.EnsureSuccessStatusCode();

        string responseText = await httpGet.Content.ReadAsStringAsync();
        var reviews = JsonConvert.DeserializeObject<ReviewDto>(responseText);
        Assert.Equal(userId, reviews.FriendId);
    }
}