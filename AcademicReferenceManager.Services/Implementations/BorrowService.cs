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
        public PublicationToFriend CreateFriendBorrowsABookConnection(PublicationToFriendInputModel body)
                 => _borrowRepo.CreateFriendBorrowsABookConnection(body);
        /*
        public IEnumerable<FriendThatBorrowedPublicationDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime date)
                => _borrowRepo.GetAllFriendsThatBorrowedPublicationsByParticularDate(date);
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(DateTime date)
                => _borrowRepo.GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(date);
        public IEnumerable<PublicationBorrowedByFriendDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date)
                => _borrowRepo.GetAllPublicationsThatAreOnLoanByParticularDate(date);
         */
    }
}