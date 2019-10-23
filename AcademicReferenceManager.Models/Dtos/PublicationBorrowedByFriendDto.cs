namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationBorrowedByFriendDto
    {
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