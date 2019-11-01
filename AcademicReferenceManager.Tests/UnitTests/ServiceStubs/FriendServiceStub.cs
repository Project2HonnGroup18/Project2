using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;

namespace UnitTests.ServiceStubs
{
    public class FriendServiceStub : IFriendService
    {
        private readonly List<Friend> _friends;
        private readonly List<Publication> _recommendations;
        public FriendServiceStub()
        {
            _friends = new List<Friend>()
            {
                new Friend()
                {
                    Id = 1,
                    FirstName = "Egill",
                    LastName = "Jóhannsson",
                    Email = "egillj17@ru.is",
                    Phone = "659 0407",
                    Address = "Reynimelur 47"
                },
                new Friend()
                {
                    Id = 2,
                    FirstName = "Árni",
                    LastName = "Magg",
                    Email = "arni@ru.is",
                    Phone = "666 6666",
                    Address = "Heima"
                },
                new Friend()
                {
                    Id = 3,
                    FirstName = "Valgarður",
                    LastName = "Ívars",
                    Email = "valli@ru.is",
                    Phone = "999 9999",
                    Address = "Heima"
                },

            };

            _recommendations = new List<Publication>()
            {
                new Publication()
                {
                    Id = 1,
                    EditorFirstName = "David",
                    EditorLastName = "David",
                    Title = "Davids pub",
                    Journal = "World Scientific",
                    Isbn = "124601285-0",
                    Year = 2019,
                    Type = "electronic"

                }
            };
        }

        public IEnumerable<FriendDto> GetAllFriends(DateTime? loanDate, int? loanDuration)
        {
            var friends = _friends.Select(f => new FriendDto
            {
                FirstName = f.FirstName,
                LastName = f.LastName,
                Email = f.Email,
                Phone = f.Phone,
                Address = f.Address
            });
            
            return friends;
        }

        public FriendDto GetFriendById(int friendId)
        {
            var friend = _friends.Where(f => f.Id == friendId).FirstOrDefault();
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {friendId} was not found");     
            }
            return new FriendDto 
            {
                FirstName = friend.FirstName,
                LastName = friend.LastName,
                Email = friend.Email,
                Phone = friend.Phone,
                Address = friend.Address
            };
        }

        public Friend CreateFriend(FriendInputModel newFriend)
        {
            newFriend.FirstName = "Lárus";
            newFriend.LastName = "Páls";
            newFriend.Email = "lp@ru.is";
            newFriend.Phone = "581 2345";
            newFriend.Address = "Laugavegur";

            var friendToAdd = new Friend()
            {
                FirstName = newFriend.FirstName,
                LastName = newFriend.LastName,
                Email = newFriend.Email,
                Phone = newFriend.Phone,
                Address = newFriend.Address
            };

            _friends.Add(friendToAdd);
            return friendToAdd;

        }

        public Friend UpdateFriendById(int friendId, FriendUpdateInputModel body)
        {
            var friend = _friends.FirstOrDefault(f => f.Id == friendId);
            
            friend.FirstName = string.IsNullOrEmpty(body.FirstName) ? friend.FirstName : body.FirstName;
            friend.LastName = string.IsNullOrEmpty(body.LastName) ? friend.LastName : body.LastName;
            friend.Email = string.IsNullOrEmpty(body.Email) ? friend.Email : body.Email;
            friend.Phone = string.IsNullOrEmpty(body.Phone) ? friend.Phone : body.Phone;
            friend.Address = string.IsNullOrEmpty(body.Address) ? friend.Address : body.Address;

            return friend;
        }

        public Friend DeleteFriendById(int friendId) 
        {
            var existing = _friends.First(f => f.Id == friendId);
            _friends.Remove(existing);
            return existing;
        }

        public IEnumerable<Publication> GetRecommendations(int userId)
        {
            return _recommendations;
        }
        
    }
}