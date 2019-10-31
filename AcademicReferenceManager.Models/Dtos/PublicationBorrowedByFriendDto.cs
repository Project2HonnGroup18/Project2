namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationBorrowedByFriendDto
    {
        public PublicationBorrowedByFriendDto(Entities.Friend friend, Entities.Publication publication)
        {
            EditorFirstName = publication.EditorFirstName;
            EditorLastName = publication.EditorLastName;
            PublicationTitle = publication.Title;
            PublicationYear = publication.Year;
            PublicationType = publication.Type;
            PublicationIsbn = publication.Isbn;
            FriendFirstName = friend.FirstName;
            FriendLastName = friend.LastName;
            FriendPhone = friend.Phone;
        }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string PublicationTitle { get; set; }
        public int? PublicationYear { get; set; }
        public string PublicationType { get; set; }
        public string PublicationIsbn { get; set; }
        public string FriendFirstName { get; set; }
        public string FriendLastName { get; set; }
        public string FriendPhone { get; set; }
    }
}