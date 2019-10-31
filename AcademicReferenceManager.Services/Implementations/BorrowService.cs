using System;
using System.Collections.Generic;
using System.Linq;
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
                => _borrowRepo.GetAllPublicationsAUserHasOnLoanById(userId).Select(pub => new PublicationDto(pub));
        
        public PublicationToFriendDto CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body) 
                => new PublicationToFriendDto(_borrowRepo.CreateFriendBorrowsABookConnection(userId, publicationId, body));
        public PublicationToFriendDto UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body)
                => new PublicationToFriendDto(_borrowRepo.UpdateFriendBorrowsABookConnection(userId, publicationId, body));
        public PublicationToFriendDto DeleteFriendBorrowsABookConnection(int userId, int publicationId)
                => new PublicationToFriendDto(_borrowRepo.DeleteFriendBorrowsABookConnection(userId, publicationId));
        }
}