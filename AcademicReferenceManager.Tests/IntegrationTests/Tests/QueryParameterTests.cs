using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.WebApi;
using Newtonsoft.Json;
using Xunit;

public class QueryParameterTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private string userBasePath = "/api/users";
    private string publicationBasePath = "/api/publications/";
    private Func<int, int, string> SpecificUserPublicationPath;
    private string authenticationName = "Role";
    private string authenticationValue = "admin";

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

    public QueryParameterTests(CustomWebApplicationFactory<Startup> factory)
    {
        SpecificUserPublicationPath = (userId, publicationId) => userBasePath + userId + "/publications/" + publicationId;

        _factory = factory;
        _client = factory.CreateClient();
    }

    //****************************************************************
    //* Tests for authentication on /api/users and /api/publications *
    //****************************************************************

    [Fact]
    public async Task GetUsersThatHavePublicationsOnLoanWhenNotAuthorizedExpectUnAuthorizedStatusCode()
    {
        string loanString = userBasePath += "?LoanDate=2015-11-19";
        var httpResponse = await _client.GetAsync(loanString);

        Assert.Equal(System.Net.HttpStatusCode.Unauthorized, httpResponse.StatusCode);
    }

   [Fact]   
    public async Task GetUserThatHavePublicationOnLoanWhileAuthorizedExpectOKStatusCode() 
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        string loanString = userBasePath += "?LoanDate=2015-11-19";
        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        Assert.Equal(System.Net.HttpStatusCode.OK, httpResponse.StatusCode);
    }

    [Fact]
    public async Task GetPublicationsOnLoanWhenNotAuthorizedExpectUnAuthorizedStatusCode()
    {
        string loanString = userBasePath += "?LoanDate=2015-11-19";
        var httpResponse = await _client.GetAsync(loanString);

        Assert.Equal(System.Net.HttpStatusCode.Unauthorized, httpResponse.StatusCode);
    }

    [Fact]
    public async Task GetPublicationOnLoanWhileAuthorizedExpectOKStatusCode() 
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        string loanString = userBasePath += "?LoanDate=2015-11-19";
        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        Assert.Equal(System.Net.HttpStatusCode.OK, httpResponse.StatusCode);
    }

    //***************************************
    //* Result tests on /api/users?LoanDate *
    //***************************************

    [Fact]
    public async Task GetUsersThatHavePublicationsOnLoan19November2015AndExpectTwo()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        string loanString = userBasePath += "?LoanDate=2015-11-19";
        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.Equal(2, userList.Count());
    }

    [Fact]
    public async Task GetUsersThatHavePublicationsOnLoan1November2000AndExpectNot2()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);

        string loanString = userBasePath += "?LoanDate=2000-11-01";
        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.NotEqual(2, userList.Count());
    }

    //**********************************************
    //* Result tests on /api/publications?LoanDate *
    //**********************************************

    [Fact]
    public async Task GetPublicationsOnLoan12October2015AndExpectOne()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = publicationBasePath += "?LoanDate=2015-10-12";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.Equal(1, userList.Count());
    }

    [Fact]
    public async Task GetPublicationsOnLoan13August1999AndExpectNotOne()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = publicationBasePath += "?LoanDate=1999-08-13";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.NotEqual(1, userList.Count());
    }

    //*******************************************
    //* Result tests on /api/users?LoanDuration *
    //*******************************************

    [Fact]
    public async Task GetUsersThatHaveHadPublicationsOnLoanForMoreThan40DaysExpectEighteen()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = userBasePath += "?LoanDuration=40";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.Equal(18, userList.Count());
    }

    [Fact]
    public async Task GetUserThatHaveHadPublicationOnLoanForMoreThan100DaysExpectNotEighteen()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = userBasePath += "?LoanDuration=100";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.NotEqual(18, userList.Count());
    }

    //*****************************************************************
    //* Result tests on /api/users?LoanDuration&LoanDate*
    //*****************************************************************

    [Fact] 
    public async Task GetUserThatHaveHadPublicationOnLoanForMoreThan100DaysGivenSpecificDateExpectOne()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = userBasePath += "?LoanDuration=10&LoanDate=2015-10-12";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.Equal(1, userList.Count());
    }

    [Fact] 
    public async Task GetUserThatHaveHadPublicationOnLoanForMoreThan30DaysGivenSpecificDateExpectNot2()
    {
        _client.DefaultRequestHeaders.Add(authenticationName, authenticationValue);
        string loanString = userBasePath += "?LoanDuration=30&LoanDate=2016-10-12";

        var httpResponse = await _client.GetAsync(loanString);
        httpResponse.EnsureSuccessStatusCode();

        var stringResponse = await httpResponse.Content.ReadAsStringAsync();
        var userList = JsonConvert.DeserializeObject<IEnumerable<PublicationDto>>(stringResponse);
        Assert.NotEqual(2, userList.Count());
    }
}