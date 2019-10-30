using System.Collections.Generic;

namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationReviewsDto
    {
        public int Id { get; set; }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public IEnumerable<ReviewDto> Reviews { get; set; }
    }
}