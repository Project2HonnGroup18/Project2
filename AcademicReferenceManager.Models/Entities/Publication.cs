using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AcademicReferenceManager.Models.Entities
{
    public class Publication
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }
        
        [BsonElement("editor_first_name")]
        public string EditorFirstName { get; set; }

        [BsonElement("editor_last_name")]
        public string EditorLastName { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("journal")]
        public string Journal { get; set; }

        [BsonElement("isbn")]
        public string Isbn { get; set; }

        [BsonElement("year")]
        public int? Year { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }
    }
}