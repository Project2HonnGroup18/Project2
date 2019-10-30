using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
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
        
        public IEnumerable<ReviewDto> GetReviewsByUser(int userId) 
        {
            System.Console.WriteLine("\n\nTEST!\n\n " + userId);
            var reviewSet =  _armDbContext.Reviews;
            var filtered = reviewSet.Where(f => userId == f.FriendId);
            var remapped = filtered.Select(r => new ReviewDto
            {
                Rating = r.Rating,
                PublicationId = r.PublicationId,
                FriendId = r.FriendId
            });

            return remapped;
        } 

        public ReviewDto GetUserReviewForPublication(int userId, int publicationId)
        {
            var review = _armDbContext.Reviews
                .FirstOrDefault(f => userId == f.FriendId && publicationId == f.PublicationId);
            var reviewDto = new ReviewDto {
                    Rating = review.Rating,
                    PublicationId = review.PublicationId,
                    FriendId = review.FriendId
            };

            return reviewDto;
        }

        public Review AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body)
        {
            var review = new Review {
                Rating = body.Rating,
                FriendId = userId,
                PublicationId = publicationId
            };

            _armDbContext.Reviews.Add(review);
            _armDbContext.SaveChanges();
            return review;
        }

        public Review DeleteReview(int userId, int publicationId) 
        {
            var review = _armDbContext.Reviews.FirstOrDefault(f => f.FriendId == userId && publicationId == f.PublicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} was not found");
            }

            _armDbContext.Remove(review);
            _armDbContext.SaveChanges();

            return review;
        }
        
    }
}