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
        FriendDto GetFriendById(int friendId);
        Friend CreateFriend(FriendInputModel body);
        Friend UpdateFriendById(int friendId, FriendUpdateInputModel body);
        Friend DeleteFriendById(int friendId);
        IEnumerable<Publication> GetRecommendations(int userId);
    }
}