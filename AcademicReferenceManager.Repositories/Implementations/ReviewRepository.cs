using System.Collections.Generic;
using System.Linq;
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
        
        public IEnumerable<Review> GetReviewsByUser(int userId) 
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            var reviewSet = _armDbContext.Reviews;
            var filtered = reviewSet.Where(f => userId == f.FriendId);
            var remapped = filtered.Select(r => new Review
            {
                Rating = r.Rating,
                PublicationId = r.PublicationId,
                FriendId = r.FriendId
            });

            return remapped;
        } 

        public Review GetUserReviewForPublication(int userId, int publicationId)
        {
            // Validate that a review from given user on given publication exists
            var review = _armDbContext.Reviews
                .FirstOrDefault(f => userId == f.FriendId && publicationId == f.PublicationId);
            if(review == null)
            {
                throw new ResourceNotFoundException($"User with id: {userId} has not reviewd publication with id: {publicationId}");
            }

            return review;
        }

        public Review AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body)
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            // Validate that given publication exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }
            // Validate that given user has borrowed given publication
            var connection = _armDbContext.PublicationsToFriend.FirstOrDefault(c => 
                                c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null) 
            {
                throw new UserHasNotBorrowedBookException($"User with id: {userId} has not borrowed publication with id: {publicationId} and therefor cannot review it");
            }
            // Validate that given user has not review given publication before
            var review = _armDbContext.Reviews.FirstOrDefault(r => r.FriendId == userId && r.PublicationId == publicationId);
            if(review != null) 
            {
                throw new ModelFormatException($"User with id: {userId} has already reviewd publication with id: {publicationId}");
            }
            
            var newReview = new Review {
                Rating = body.Rating,
                FriendId = userId,
                PublicationId = publicationId
            };

            _armDbContext.Reviews.Add(newReview);
            _armDbContext.UpdateRatingForPublication(publicationId);
            _armDbContext.SaveChanges();
            return newReview;
        }

        public IEnumerable<Publication> GetAllReviewsForAllPublications() 
        {
            var publications = _armDbContext.Publications.Include(p => p.Reviews).ToList();

            return publications;
        }

        public Review DeleteReview(int userId, int publicationId) 
        {
            // Validate that given user has reviewed given publication
            var review = _armDbContext.Reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"Review from user with id: {userId} on publication with id: {publicationId} was not found");
            }

            _armDbContext.Remove(review);
            _armDbContext.UpdateRatingForPublication(publicationId);
            _armDbContext.SaveChanges();

            return review;
        }
        public Review UpdateReview(int userId, int publicationId, ReviewInputModel body) 
        {
            // Validate that given user has reviewed given publication
            var review = _armDbContext.Reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"Review from user with id: {userId} on publication with id: {publicationId} was not found");
            }
            
            review.Rating = body.Rating;
            _armDbContext.UpdateRatingForPublication(publicationId);
            _armDbContext.SaveChanges();

            return review;
        }
        
        public Publication GetAllReviewsByPublicationId(int publicationId)
        {
            // Validate that given publication exists
            var publication = _armDbContext.Publications.Include(p => p.Reviews).FirstOrDefault(p => p.Id == publicationId);
            return publication;

        }
        public Review GetAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input - Return and return the review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            return review;
        }
        public Review UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body)
        {
            // Validate input and update review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            review.Rating = body.Rating;
            _armDbContext.UpdateRatingForPublication(publicationId);
            _armDbContext.SaveChanges();

            return review;
        }
        public Review DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input and remove review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            _armDbContext.Remove(review);
            _armDbContext.UpdateRatingForPublication(publicationId);
            _armDbContext.SaveChanges();

            return review;
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