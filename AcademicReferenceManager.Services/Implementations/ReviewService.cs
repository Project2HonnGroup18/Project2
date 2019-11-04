using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
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

        public IEnumerable<ReviewDto> GetReviewsByUser(int userId) 
            => _reviewRepo.GetReviewsByUser(userId).Select(r => new ReviewDto(r));
        public ReviewDto GetUserReviewForPublication(int userId, int publicationId)
            => new ReviewDto(_reviewRepo.GetUserReviewForPublication(userId, publicationId));
        public IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications() 
            => _reviewRepo.GetAllReviewsForAllPublications().Select(p => new PublicationReviewsDto(p));
        public ReviewDto AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body) 
            => new ReviewDto(_reviewRepo.AddUserReviewForPublication(userId, publicationId, body));
        public ReviewDto DeleteReview(int userId, int publicationId) 
            => new ReviewDto(_reviewRepo.DeleteReview(userId, publicationId));
        public ReviewDto UpdateReview(int userId, int publicationId, ReviewInputModel body) 
            => new ReviewDto(_reviewRepo.UpdateReview(userId, publicationId, body));
        public PublicationReviewsDto GetAllReviewsByPublicationId(int publicationId)
            => new PublicationReviewsDto(_reviewRepo.GetAllReviewsByPublicationId(publicationId));
        public ReviewDto GetAReviewForASpecificPublicationByUserId(int publicationId, int userId)
            => new ReviewDto(_reviewRepo.GetAReviewForASpecificPublicationByUserId(publicationId, userId));
        public ReviewDto UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body)
            => new ReviewDto(_reviewRepo.UpdateAReviewForASpecificPublicationByUserId(publicationId, userId, body));
        public ReviewDto DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId) 
            => new ReviewDto(_reviewRepo.DeleteAReviewForASpecificPublicationByUserId(publicationId, userId));
    }
}