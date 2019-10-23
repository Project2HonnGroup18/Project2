using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class FriendRepository : IFriendRepository
    {
        private readonly IFriendDbContext _friendDbContext;

        public FriendRepository(IFriendDbContext fDbContext) 
        {
            _friendDbContext = fDbContext;
        }

        public IEnumerable<FriendDto> GetAllFriends() => _friendDbContext.Friends.Select(f => new FriendDto
        {
            Id = f.Id,
            FirstName = f.FirstName,
            LastName = f.LastName,
            Email = f.Email,
            Phone = f.Phone,
            Address = f.Address
        });

        public FriendDto GetFriendById(int friendId)
        {
             var friend = _friendDbContext.Friends.FirstOrDefault(f => f.Id == friendId);
             if(friend == null)
             {
                 throw new ResourceNotFoundException($"Friend with id: {friendId} was not found");
             }
             return new FriendDto
             {
                 Id = friend.Id,
                 FirstName = friend.FirstName,
                 LastName = friend.LastName,
                 Email = friend.Email,
                 Phone = friend.Phone,
                 Address = friend.Address
             };
        }

        public Friend CreateFriend(FriendInputModel body)
        {
            int nextInt = 0;
            if(_friendDbContext.Friends.Count == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _friendDbContext.Friends.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            }
            var entity = new Friend
            {
                Id = nextInt,
                FirstName = body.FirstName,
                LastName = body.LastName,
                Email = body.Email,
                Phone = body.Phone,
                Address = body.Address
            };

            _friendDbContext.Friends.Add(entity);
            return entity;
        }
    }
}