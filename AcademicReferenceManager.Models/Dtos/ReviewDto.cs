namespace AcademicReferenceManager.Models.Dtos
{
    public class ReviewDto
    {
        public ReviewDto(Entities.Review review)
        {
            Rating = review.Rating;
            PublicationId = review.PublicationId;
            FriendId = review.FriendId;
        }

        public int Rating { get; set; }
        public int PublicationId { get; set; }
        public int FriendId { get; set; }
    
    }
}