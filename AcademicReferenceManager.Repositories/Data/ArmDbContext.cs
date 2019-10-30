using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Repositories.Seeding;
using Microsoft.EntityFrameworkCore;

namespace AcademicReferenceManager.Repositories.Data {
    public class ArmDbContext : DbContext
    {
        DatabaseSeeder _seeder;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(_seeder.friends);
            modelBuilder.Entity<Publication>().HasData(_seeder.publications);
            modelBuilder.Entity<PublicationToFriend>().HasData(_seeder.borrows);
        
        }

        public ArmDbContext(DatabaseSeeder seeder, DbContextOptions<ArmDbContext> options): base(options)
        {
            _seeder = seeder;
        }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationToFriend> PublicationsToFriend { get; set;} 
    }
}