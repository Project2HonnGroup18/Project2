using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IFriendRepository
    {
        IEnumerable<Friend> GetAllFriends();
        Friend GetFriendById(int friendId);
        Friend CreateFriend(FriendInputModel body);
        Friend UpdateFriendById(int userId, FriendUpdateInputModel body);
        Friend DeleteFriendById(int userId);
        IEnumerable<Publication> GetRecommendations(int userId); 
    }
}

