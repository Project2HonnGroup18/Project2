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
        public FriendService(IFriendRepository friendRepo)
        {
            _friendRepo = friendRepo;
        }
        public IEnumerable<FriendDto> GetAllFriends() => _friendRepo.GetAllFriends();
        public FriendDto GetFriendById(int friendId) => _friendRepo.GetFriendById(friendId);
        public Friend CreateFriend(FriendInputModel body) => _friendRepo.CreateFriend(body);
    }
}