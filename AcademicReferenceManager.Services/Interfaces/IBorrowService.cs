using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IBorrowService
    {
        IEnumerable<PublicationDto> GetAllPublicationsAUserHasOnLoanById(int userId);
        PublicationToFriendDto CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriendDto UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriendDto DeleteFriendBorrowsABookConnection(int userId, int publicationId);
    }
}