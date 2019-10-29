using AcademicReferenceManager.Models.Database;
using AcademicReferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace AcademicReferenceManager.Repositories.Data {
    public class ArmDbContext 
    {
        private readonly IMongoDatabase _database = null;

        public ArmDbContext(IOptions<ArmDatabaseSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<Friend> Friends
        {
            get
            {
                return _database.GetCollection<Friend>("friends");
            }
        }
        public IMongoCollection<Publication> Publications { get; set; }
        public IMongoCollection<PublicationToFriend> Borrows { get; set;} 
    }
}