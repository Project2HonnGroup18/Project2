using System.ComponentModel.DataAnnotations;

namespace AcademicReferenceManager.Models.InputModels
{
    public class FriendInputModel
    {
        [Required]
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public string Address { get; set; }
        
    }
}