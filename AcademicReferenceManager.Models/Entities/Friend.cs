using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AcademicReferenceManager.Models.Entities
{
    public class Friend
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("publications")]
        public List<PublicationToFriend> Publications { get; set; }
        
    }
}