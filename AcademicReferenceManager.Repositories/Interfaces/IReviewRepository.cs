using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<ReviewDto> GetReviewsByUser(int friendId);
        Review AddUserReviewForPublication(int friendId, int publicationId, ReviewInputModel body);
        IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications();

    }
}