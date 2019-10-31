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

        public Review DeleteReview(int userId, int publicationId) 
        {
            var review = _armDbContext.Reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }

            _armDbContext.Remove(review);
            _armDbContext.SaveChanges();

            return review;
        }
        public Review UpdateReview(int userId, int publicationId, ReviewInputModel body) 
        {
            var review = _armDbContext.Reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} was not found");
            }
            
            review.Rating = body.Rating;
            _armDbContext.SaveChanges();

            return review;
        }
        
        public PublicationReviewsDto GetAllReviewsByPublicationId(int publicationId)
        {
            // Validate that given publication exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }

            // Find all reviews for given publication
            var reviews = _armDbContext.Reviews.Where(r => r.PublicationId == publicationId).Select(rdto => new ReviewDto 
                {
                    FriendId = rdto.FriendId,
                    PublicationId = rdto.PublicationId,
                    Rating = rdto.Rating
                });

            return new PublicationReviewsDto {
                Id = publicationId,
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Reviews = reviews
            };

        }
        public ReviewDto GetAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input - Return and return the review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }
        public ReviewDto UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body)
        {
            // Validate input and update review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            review.Rating = body.Rating;
            _armDbContext.SaveChanges();

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }
        public ReviewDto DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input and remove review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            _armDbContext.Remove(review);
            _armDbContext.SaveChanges();

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }

        //********************
        //* Helper functions *
        //********************
        private Review ValidateInputsForAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Check if publication with given publication id exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }

            // Check if user with given user id exists
            var user = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(user == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            
            // Validate that given user has reviewed given publication
            var review = _armDbContext.Reviews.FirstOrDefault(r => r.PublicationId == publicationId && r.FriendId == userId);
            if(review == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} has not been reviewd by user with id {userId}");
            }

            return review;
        }
    }
}