namespace AcademicReferenceManager.Models.Dtos
{
    public class FriendDto
    {
        public FriendDto() {}
        public FriendDto(Entities.Friend friend)
        {
            Id = friend.Id;
            FirstName = friend.FirstName;
            LastName = friend.LastName;
            Email = friend.Email;
            Phone = friend.Phone;
            Address = friend.Address;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}