using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IFriendService
    {
        IEnumerable<FriendDto> GetAllFriends(DateTime? loanDate, int? loanDuration);
        FriendWithBorrowHistoryDto GetFriendById(int friendId);
        FriendDto CreateFriend(FriendInputModel body);
        FriendDto UpdateFriendById(int friendId, FriendUpdateInputModel body);
        FriendDto DeleteFriendById(int friendId);
        IEnumerable<PublicationDto> GetRecommendations(int userId);
    }
}