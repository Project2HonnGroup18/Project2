namespace AcademicReferenceManager.Models.Dtos
{
    public class PublicationDto
    {
        public PublicationDto(){}
        public PublicationDto(Entities.Publication pub)
        {
            Id = pub.Id;
            EditorFirstName = pub.EditorFirstName;
            EditorLastName = pub.EditorLastName;
            Title = pub.Title;
            Year = pub.Year;
            Type = pub.Type;
            Isbn = pub.Isbn;
            Rating = (float)pub.Rating;
        }
        public int Id { get; set; }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }
        public string Isbn { get; set; }
        public float Rating { get; set; }
    }
}