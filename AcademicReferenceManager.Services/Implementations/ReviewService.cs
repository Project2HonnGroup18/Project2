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

        public IEnumerable<ReviewDto> GetReviewsByUser(int friendId) => _reviewRepo.GetReviewsByUser(friendId);

        public Review AddUserReviewForPublication(int friendId, int publicationId, ReviewInputModel body) 
            => _reviewRepo.AddUserReviewForPublication(friendId, publicationId, body);
        public IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications() 
            => _reviewRepo.GetAllReviewsForAllPublications();


    }
}