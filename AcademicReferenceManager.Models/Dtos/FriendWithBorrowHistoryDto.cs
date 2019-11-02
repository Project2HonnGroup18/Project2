using System.Collections.Generic;
using System.Linq;

namespace AcademicReferenceManager.Models.Dtos
{
    public class FriendWithBorrowHistoryDto
    {
        public FriendWithBorrowHistoryDto() {}
        public FriendWithBorrowHistoryDto(Entities.Friend friend)
        {
            Id = friend.Id;
            FirstName = friend.FirstName;
            LastName = friend.LastName;
            Email = friend.Email;
            Phone = friend.Phone;
            Address = friend.Address;
            BorrowHistory = friend.PublicationsToFriend.Select(p2f => new PublicationToFriendDto(p2f));
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public IEnumerable<PublicationToFriendDto> BorrowHistory { get; set; }
    }
}