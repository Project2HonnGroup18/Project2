using System.Collections.Generic;
using System.Linq;

namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationWithBorrowHistoryDto
    {
        public PublicationWithBorrowHistoryDto(){}
        public PublicationWithBorrowHistoryDto(Entities.Publication pub)
        {
            Id = pub.Id;
            EditorFirstName = pub.EditorFirstName;
            EditorLastName = pub.EditorLastName;
            Title = pub.Title;
            Year = pub.Year;
            Type = pub.Type;
            Isbn = pub.Isbn;
            Rating = (float)pub.Rating;
            BorrowHistory = pub.PublicationsToFriend.Select(p2f => new PublicationToFriendDto(p2f));
        }
        public int Id { get; set; }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }
        public string Isbn { get; set; }
        public float Rating { get; set; }
        public IEnumerable<PublicationToFriendDto> BorrowHistory { get; set; }
    }
}