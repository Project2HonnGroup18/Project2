using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<ReviewDto> GetReviewsByUser(int userId);
        ReviewDto GetUserReviewForPublication(int userId, int publicationId);
        Review AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body);
        Review DeleteReview(int userId, int publicationId);
        Review UpdateReview(int userId, int publicationId, ReviewInputModel body);
        IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications();
        PublicationReviewsDto GetAllReviewsByPublicationId(int publicationId);
        ReviewDto GetAReviewForASpecificPublicationByUserId(int publicationId, int userId);
        ReviewDto UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body);
        ReviewDto DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId);

    }
}