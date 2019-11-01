using System.Linq;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Repositories.Seeding;
using Microsoft.EntityFrameworkCore;

namespace AcademicReferenceManager.Repositories.Data {
    public class ArmDbContext : DbContext
    {
        DatabaseSeeder _seeder;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasKey(o => new {o.FriendId, o.PublicationId});

            if(_seeder != null)
            {
                modelBuilder.Entity<Friend>().HasData(_seeder.friends);
                modelBuilder.Entity<Publication>().HasData(_seeder.publications);
                modelBuilder.Entity<PublicationToFriend>().HasData(_seeder.borrows);
                modelBuilder.Entity<Review>().HasData(_seeder.reviews);
            }
        }

        
        public void UpdateRatingForPublication(int publicationId)
        {
            var publication = Publications.Include(pub => pub.Reviews).Where(p => p.Id == publicationId).FirstOrDefault();
            if(publication.Reviews.Count > 0)
                publication.Rating = publication.Reviews.Average(rev => rev.Rating);
            else
                publication.Rating = 0;
            Publications.Update(publication);
        }

        public void UpdateRatingForAllPublications()
        {
            var publications = Publications
                                .Include(pub => pub.Reviews)
                                .Where(p => p.Reviews.Count != 0);
            foreach(var publication in publications)
            {
                publication.Rating = publication.Reviews.Average(rev => rev.Rating);
            }
            Publications.UpdateRange(publications);
        }

        public ArmDbContext(DbContextOptions<ArmDbContext> options, DatabaseSeeder seeder = null): base(options)
        {
            _seeder = seeder;
        }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationToFriend> PublicationsToFriend { get; set;}
        public DbSet<Review> Reviews { get; set; }
    }
}