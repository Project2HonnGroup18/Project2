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
            IEnumerable<Friend> friendList;
            if(loanDate.HasValue && loanDuration.HasValue)
            {
                friendList = _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate((DateTime) loanDate, (int) loanDuration);
            }
            else if(loanDuration.HasValue)
            {
                friendList = _borrowRepo.GetAllFriendsThatBorrowedForLongerThanParticularDuration((int) loanDuration);
            }
            else if(loanDate.HasValue)
            {
                friendList = _borrowRepo.GetAllFriendsThatHaveAPublicationOnLoanByParticularDate((DateTime) loanDate);
            }
            else 
            {
                friendList = _friendRepo.GetAllFriends();
            }
            return friendList.Select(f => new FriendDto(f));
        }

        public FriendWithBorrowHistoryDto GetFriendById(int friendId) => new FriendWithBorrowHistoryDto(_friendRepo.GetFriendById(friendId));
        public FriendDto CreateFriend(FriendInputModel body) => new FriendDto(_friendRepo.CreateFriend(body));
        public FriendDto UpdateFriendById(int friendId, FriendUpdateInputModel body) => new FriendDto(_friendRepo.UpdateFriendById(friendId, body));
        public FriendDto DeleteFriendById(int friendId) => new FriendDto(_friendRepo.DeleteFriendById(friendId));
        public IEnumerable<PublicationDto> GetRecommendations(int userId) => _friendRepo.GetRecommendations(userId).Select(pub => new PublicationDto(pub));
    }
}