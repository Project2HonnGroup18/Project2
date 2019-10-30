using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ArmDbContext _armDbContext;

        public ReviewRepository(ArmDbContext armDbContext) 
        {
            _armDbContext = armDbContext;
        }
        
        public IEnumerable<ReviewDto> GetReviewsByUser(int friendId) 
        {
            System.Console.WriteLine("\n\nTEST!\n\n " + friendId);
            var reviewSet =  _armDbContext.Reviews;
            var filtered = reviewSet.Where(f => friendId == f.FriendId);
            var remapped = filtered.Select(r => new ReviewDto
            {
                Rating = r.Rating,
                PublicationId = r.PublicationId,
                FriendId = r.FriendId
            });

            return remapped;
        } 

        public Review AddUserReviewForPublication(int friendId, int publicationId, ReviewInputModel body)
        {
            var review = new Review {
                Rating = body.Rating,
                FriendId = friendId,
                PublicationId = publicationId
            };

            _armDbContext.Reviews.Add(review);
            _armDbContext.SaveChanges();
            return review;
        }

        public IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications() 
        {
            var publications = _armDbContext.Publications.ToList();
            List<PublicationReviewsDto> publicationReviews = new List<PublicationReviewsDto>();

            foreach(Publication p in publications)
            {
                var reviews = _armDbContext.Reviews.Where(r => r.PublicationId == p.Id).Select(rdto => new ReviewDto 
                {
                    FriendId = rdto.FriendId,
                    PublicationId = rdto.PublicationId,
                    Rating = rdto.Rating
                });
                publicationReviews.Add(new PublicationReviewsDto 
                {
                    Id = p.Id,
                    EditorFirstName = p.EditorFirstName,
                    EditorLastName = p.EditorLastName,
                    Title = p.Title,
                    Reviews = reviews
                });
            }

            return publicationReviews;
        }

        
    }
}