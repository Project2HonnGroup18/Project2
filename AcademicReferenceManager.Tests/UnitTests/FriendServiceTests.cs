using System;
using Xunit;
using AcademicReferenceManager.Services.Implementations;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Implementations;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Entities;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UnitTests
{
    //TODO: full CRUD testing
    public class FriendServiceTests
    {
        public readonly FriendService _friendService;
        public readonly FriendInputModel _inputModel;
        public FriendServiceTests()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ArmDbContext>().UseInMemoryDatabase("InMemoryDatabase");
            ArmDbContext db = new ArmDbContext(options: dbOptionsBuilder.Options);
 
            FriendRepository friendRepository = new FriendRepository(db);
            _friendService = new FriendService(friendRepository);

            _inputModel =  new FriendInputModel();
            _inputModel.FirstName = "Dommi";
            _inputModel.LastName = "Nostredamus";
            _inputModel.Phone = "5812345";
            _inputModel.Address = "Skeifan 17";
            _inputModel.Email = "valli@valli.is";
        }

        [Fact]
        public void TestGettingAllFriends()
        {
            var friends = _friendService.GetAllFriends();
            Assert.NotNull(friends);
        }

        [Fact]
        public void TestAddingFriendByComparison()
        {

            Friend createdFriend = _friendService.CreateFriend(_inputModel);
            bool sameFriend = createdFriend.FirstName == _inputModel.FirstName;
            sameFriend = sameFriend && createdFriend.LastName == _inputModel.LastName;
            sameFriend = sameFriend && createdFriend.Phone == _inputModel.Phone;
            sameFriend = sameFriend && createdFriend.Address == _inputModel.Address;
            sameFriend = sameFriend && createdFriend.Email == _inputModel.Email;
            Assert.True(sameFriend);
        }

        [Fact]
        public void TestAddingFriendByCounting()
        {
            // Get original people list size, add friend then re-fetch the size.
            // Underlying implementation is unknown, so we cannot rely on the original list changing in size.
            int originalCount = _friendService.GetAllFriends().ToList().Count;
            Friend createdFriend = _friendService.CreateFriend(_inputModel);
            int newCount = _friendService.GetAllFriends().ToList().Count;

            Assert.Equal(originalCount + 1, newCount);
        }

        [Fact]
        public void TestAddingFriendAndUsingId()
        {

            Friend createdFriend = _friendService.CreateFriend(_inputModel);
            FriendDto reFriend = _friendService.GetFriendById(createdFriend.Id);

            bool sameFriend = createdFriend.Id == reFriend.Id;
            sameFriend = sameFriend && createdFriend.FirstName == reFriend.FirstName;
            sameFriend = sameFriend && createdFriend.LastName == reFriend.LastName;
            sameFriend = sameFriend && createdFriend.Phone == reFriend.Phone;
            sameFriend = sameFriend && createdFriend.Address == reFriend.Address;
            sameFriend = sameFriend && createdFriend.Email == reFriend.Email;
            Assert.True(sameFriend);
        }
    }
}
