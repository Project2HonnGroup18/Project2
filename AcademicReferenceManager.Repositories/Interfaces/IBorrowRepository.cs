using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IBorrowRepository
    {
        IEnumerable<Friend> GetAllFriendsThatHaveAPublicationOnLoanByParticularDate(DateTime? date);
        IEnumerable<Friend> GetAllFriendsThatBorrowedForLongerThanParticularDuration(int? loanDuration);
        IEnumerable<Publication> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime? date);
        IEnumerable<Friend> GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(DateTime? loanDate, int? loanDuration);
        IEnumerable<Publication> GetAllPublicationsAUserHasOnLoanById(int userId);
        PublicationToFriend CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body);
        PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId);
    }
}