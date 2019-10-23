using System;

namespace AcademicReferenceManager.Models.Entities
{
    public class PublicationToFriend
    {
        public int Id { get; set; }
        public int FriendId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int PublicationId { get; set; }

    }
}