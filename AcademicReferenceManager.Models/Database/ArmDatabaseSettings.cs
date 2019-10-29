namespace AcademicReferenceManager.Models.Database
{
    public class ArmDatabaseSettings : IArmDatabaseSettings
    {
        public string FriendsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IArmDatabaseSettings
    {
        string FriendsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}