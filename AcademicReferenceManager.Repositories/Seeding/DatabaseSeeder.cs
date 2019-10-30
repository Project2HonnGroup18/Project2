using System.Collections.Generic;
using System.IO;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Repositories.Data;
using Newtonsoft.Json;

namespace AcademicReferenceManager.Repositories.Seeding
{
    public class DatabaseSeeder
    {
        public List<Friend> friends;
        public List<Publication> publications;
        public List<PublicationToFriend> borrows;

        public DatabaseSeeder(string path = "")
        {
            if(path == "")
                path = "SeedData/";
            if(!path.EndsWith("/"))
                path += "/";
            
            string friendText = File.ReadAllText(path + "Friends.json");
            string publicationText = File.ReadAllText(path + "Publications.json");
            string borrowText = File.ReadAllText(path + "borrows.json");

            friends = JsonConvert.DeserializeObject<List<Friend>>(friendText);
            publications = JsonConvert.DeserializeObject<List<Publication>>(publicationText);
            borrows = JsonConvert.DeserializeObject<List<PublicationToFriend>>(borrowText);
        }

        public void seedDatabase(ArmDbContext dbContext)
        {
            dbContext.Friends.AddRange(friends);
            dbContext.Publications.AddRange(publications);
            dbContext.PublicationsToFriend.AddRange(borrows);
            dbContext.SaveChanges();
        }
    }
}