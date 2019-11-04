using System;
using System.Collections.Generic;
using System.Net.Http;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.WebApi;
using Xunit;

public class QueryParameterTests : IClassFixture<CustomWebApplicationFactory<Startup>>
{
    private string userBasePath = "/api/users/";
    private string publicationBasePath = "/api/publications/";
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
}