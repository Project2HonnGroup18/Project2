using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IFriendService
    {
        IEnumerable<FriendDto> GetAllFriends();
        FriendDto GetFriendById(int friendId);
        Friend CreateFriend(FriendInputModel body);
    }
}