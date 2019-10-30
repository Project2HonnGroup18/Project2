using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademicReferenceManager.Models.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        [InverseProperty("Friend")]
        public List<PublicationToFriend> PublicationsToFriend { get; set; }

        [InverseProperty("Friend")]
        public List<Review> Reviews { get; set; }        
    }
}