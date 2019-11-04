using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetReviewsByUser(int userId);
        Review GetUserReviewForPublication(int userId, int publicationId);
        Review AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body);
        Review DeleteReview(int userId, int publicationId);
        Review UpdateReview(int userId, int publicationId, ReviewInputModel body);
        //Returns list of publications, all with reviews populated
        IEnumerable<Publication> GetAllReviewsForAllPublications();
        //Returns publication with reviews list populated
        Publication GetAllReviewsByPublicationId(int publicationId);
        Review GetAReviewForASpecificPublicationByUserId(int publicationId, int userId);
        Review UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body);
        Review DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId);

    }
}