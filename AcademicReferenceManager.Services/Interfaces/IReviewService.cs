using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IReviewService
    {
        IEnumerable<ReviewDto> GetReviewsByUser(int userId);
        ReviewDto GetUserReviewForPublication(int userId, int publicationId);
        IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications();
        ReviewDto AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body);
        ReviewDto DeleteReview(int userId, int publicationId);
        ReviewDto UpdateReview(int userId, int publicationId, ReviewInputModel body);
        PublicationReviewsDto GetAllReviewsByPublicationId(int publicationId);
        ReviewDto GetAReviewForASpecificPublicationByUserId(int publicationId, int userId);
        ReviewDto UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body);
        ReviewDto DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId);
    }
}