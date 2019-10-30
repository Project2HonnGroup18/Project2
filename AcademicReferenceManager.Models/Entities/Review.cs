namespace AcademicReferenceManager.Models.Entities
{
    public class Review
    {
        public int Rating { get; set; }
        public int FriendId { get; set; }
        public Friend Friend { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
    }
}