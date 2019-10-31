using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Services.Interfaces;

namespace AcademicReferenceManager.Services.Implementations
{
    public class BorrowService : IBorrowService
    {
        private readonly IBorrowRepository _borrowRepo;

        public BorrowService(IBorrowRepository borrowRepo)
        {
            _borrowRepo = borrowRepo;
        }
        public IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections() 
                => _borrowRepo.GetAllFriendBorrowsABookConnections();
        public PublicationToFriendDto GetBorrowConnectionById(int connectionId) 
                => _borrowRepo.GetBorrowConnectionById(connectionId);
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime? loanDate)
                => _borrowRepo.GetAllFriendsThatHaveAPublicationOnLoanByParticularDate(loanDate);
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDuration(int? loanDuration)
                => _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDuration(loanDuration);
        public IEnumerable<PublicationDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime? date)
                => _borrowRepo.GetAllPublicationsThatAreOnLoanByParticularDate(date);
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(DateTime? loanDate, int? loanDuration)
                => _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(loanDate, loanDuration);
        public IEnumerable<PublicationDto> GetAllPublicationsAUserHasOnLoanById(int userId)
                => _borrowRepo.GetAllPublicationsAUserHasOnLoanById(userId);
        public PublicationToFriend CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body) 
                => _borrowRepo.CreateFriendBorrowsABookConnection(userId, publicationId, body);
        public PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body)
                => _borrowRepo.UpdateFriendBorrowsABookConnection(userId, publicationId, body);
        public PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId)
                => _borrowRepo.DeleteFriendBorrowsABookConnection(userId, publicationId);
        }
}