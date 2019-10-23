using System.ComponentModel.DataAnnotations;
using AcademicReferenceManager.Models.Attributes;

namespace AcademicReferenceManager.Models.InputModels
{
    public class PublicationInputModel
    {
        [Required]
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public string Journal { get; set; }
        public string Isbn { get; set; }
        public int Year { get; set; }
        [Required]
        [Type]
        public string Type { get; set; }
    }
}