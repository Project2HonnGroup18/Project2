using AcademicReferenceManager.Models.Database;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Services.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace AcademicReferenceManager.Services.Implementations
{
    public class NewFriendService : INewFriendService
    {
        private readonly IMongoCollection<Friend> _friends;

        public NewFriendService(IArmDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _friends = database.GetCollection<Friend>(settings.FriendsCollectionName);
        }

        public List<Friend> Get() =>
            _friends.Find(book => true).ToList();
    }
}