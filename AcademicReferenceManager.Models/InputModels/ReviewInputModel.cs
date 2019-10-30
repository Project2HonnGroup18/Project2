using System.ComponentModel.DataAnnotations;

namespace AcademicReferenceManager.Models.InputModels
{
    public class ReviewInputModel
    {
        [Required]
        public int Rating { get; set; }
    }
}