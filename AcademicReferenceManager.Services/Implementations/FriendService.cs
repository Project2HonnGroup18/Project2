using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Services.Interfaces;

namespace AcademicReferenceManager.Services.Implementations
{
    public class FriendService : IFriendService
    {
        private readonly IFriendRepository _friendRepo;
        private readonly IBorrowRepository _borrowRepo;
        public FriendService(IFriendRepository friendRepo, IBorrowRepository borrowRepo)
        {
            _friendRepo = friendRepo;
            _borrowRepo = borrowRepo;
        }
        public IEnumerable<FriendDto> GetAllFriends(DateTime? loanDate, int? loanDuration) 
        {
            if(loanDate.HasValue && loanDuration.HasValue)
            {
                return _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(loanDate, loanDuration);
            }
            else if(loanDuration.HasValue)
            {
                return _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDuration(loanDuration);
            }
            else if(loanDate.HasValue)
            {
                return _borrowRepo.GetAllFriendsThatHaveAPublicationOnLoanByParticularDate(loanDate);
            }
            else 
            {
                return _friendRepo.GetAllFriends();
            }
        }
        public FriendDto GetFriendById(int friendId) => _friendRepo.GetFriendById(friendId);
        public Friend CreateFriend(FriendInputModel body) => _friendRepo.CreateFriend(body);
        public Friend UpdateFriendById(int friendId, FriendUpdateInputModel body) => _friendRepo.UpdateFriendById(friendId, body);
        public Friend DeleteFriendById(int friendId) => _friendRepo.DeleteFriendById(friendId);
        public IEnumerable<Publication> GetRecommendations(int userId) => _friendRepo.GetRecommendations(userId);
    }
}