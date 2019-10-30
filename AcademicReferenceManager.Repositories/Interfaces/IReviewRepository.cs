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
    }
}