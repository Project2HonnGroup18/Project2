using System;
using MongoDB.Bson.Serialization.Attributes;

namespace AcademicReferenceManager.Models.Entities
{
    public class PublicationToFriend
    {

        [BsonElement("id")]
        public int Id { get; set; }
        //public int FriendId { get; set; }

        [BsonElement("borrow_date")]

        public DateTime BorrowDate { get; set; }

        [BsonElement("return_date")]

        public DateTime ReturnDate { get; set; }

        //public int PublicationId { get; set; }

    }
}