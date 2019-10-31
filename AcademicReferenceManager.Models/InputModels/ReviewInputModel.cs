using System.ComponentModel.DataAnnotations;

namespace AcademicReferenceManager.Models.InputModels
{
    public class ReviewInputModel
    {
        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }
    }
}