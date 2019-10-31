using System.Collections.Generic;
using System.Linq;

namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationReviewsDto
    {
        public PublicationReviewsDto(Entities.Publication publication)
        {
            Id = publication.Id;
            EditorFirstName = publication.EditorFirstName;
            EditorLastName = publication.EditorLastName;
            Title = publication.Title;
            Reviews = publication.Reviews.Select(r => new ReviewDto(r)); 
        }

        public int Id { get; set; }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public IEnumerable<ReviewDto> Reviews { get; set; }
    }
}