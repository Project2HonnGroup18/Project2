using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Services.Interfaces;

namespace AcademicReferenceManager.Services.Implementations
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepo;

        public ReviewService(IReviewRepository reviewRepo) 
        {
            _reviewRepo = reviewRepo;
        }

        public IEnumerable<ReviewDto> GetReviewsByUser(int userId) => _reviewRepo.GetReviewsByUser(userId);
        public ReviewDto GetUserReviewForPublication(int userId, int publicationId) => _reviewRepo.GetUserReviewForPublication(userId, publicationId);
        public Review AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body) => _reviewRepo.AddUserReviewForPublication(userId, publicationId, body);
        public Review DeleteReview(int userId, int publicationId) => _reviewRepo.DeleteReview(userId, publicationId);
    }
}