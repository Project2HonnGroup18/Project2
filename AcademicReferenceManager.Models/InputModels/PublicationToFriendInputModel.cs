using System;

namespace AcademicReferenceManager.Models.InputModels
{
    public class PublicationToFriendInputModel
    {
        public DateTime? BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}