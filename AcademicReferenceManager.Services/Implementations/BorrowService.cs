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