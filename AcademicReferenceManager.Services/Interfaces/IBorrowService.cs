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
        IEnumerable<FriendThatBorrowedPublicationDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime date);
        IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(DateTime date);
        IEnumerable<PublicationBorrowedByFriendDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date);
        IEnumerable<PublicationDto> GetAllPublicationsAUserHasOnLoanById(int userId);
        PublicationToFriend CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId);
    }
}