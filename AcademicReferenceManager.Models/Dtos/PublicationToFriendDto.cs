using System;

namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationToFriendDto
    {
        public PublicationToFriendDto(Entities.PublicationToFriend p2f)
        {
            FriendId = p2f.FriendId;
            BorrowDate = p2f.BorrowDate;
            ReturnDate = p2f.ReturnDate;
            PublicationId = p2f.PublicationId;
        }
        public int FriendId { get; set; }

        public DateTime? BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public int PublicationId { get; set; }
    }
}