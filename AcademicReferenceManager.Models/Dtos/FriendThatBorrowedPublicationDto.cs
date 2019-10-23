using System.Collections.Generic;

namespace AcademicReferenceManager.Models.Dtos
{
    public class FriendThatBorrowedPublicationDto
    {
        public string FriendFirstName { get; set; }
        public string FriendLastName { get; set; }
        public string FriendPhone { get; set; }
        public string PublicationTitle { get; set; }
    }
}