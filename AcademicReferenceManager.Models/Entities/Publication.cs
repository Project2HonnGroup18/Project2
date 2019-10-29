namespace AcademicReferenceManager.Models.Entities
{
    public class Publication
    {
        public int Id { get; set; }
        public string EditorFirstName { get; set; }
        public string EditorLastName { get; set; }
        public string Title { get; set; }
        public string Journal { get; set; }
        public string Isbn { get; set; }
        public int? Year { get; set; }
        public string Type { get; set; }
    }
}