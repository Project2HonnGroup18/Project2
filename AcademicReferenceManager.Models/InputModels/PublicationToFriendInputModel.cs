using System;
using System.ComponentModel.DataAnnotations;

namespace AcademicReferenceManager.Models.InputModels
{
    public class PublicationToFriendInputModel
    {
        [Required]
        public int FriendId { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        
        [Required]
        public DateTime ReturnDate { get; set; }
       
        [Required]
        public int PublicationId { get; set; }

    }
}