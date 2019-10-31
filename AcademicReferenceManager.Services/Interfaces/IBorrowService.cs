using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IBorrowService
    {
        IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections();
        PublicationToFriendDto GetBorrowConnectionById(int connectionId);
        IEnumerable<FriendDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime? date);
        IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDuration(int? date);
        IEnumerable<PublicationDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime? date);
        IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(DateTime? loanDate, int? loanDuration);
        IEnumerable<PublicationDto> GetAllPublicationsAUserHasOnLoanById(int userId);
        PublicationToFriend CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId);
    }
}