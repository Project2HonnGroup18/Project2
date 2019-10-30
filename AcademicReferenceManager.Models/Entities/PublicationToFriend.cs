using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicReferenceManager.Models.Entities
{
    public class PublicationToFriend
    {
        public int Id { get; set; }

        public DateTime? BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        
        public int FriendId { get; set; }
        public Friend Friend { get; set; }

    }
}