using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class FriendRepository : IFriendRepository
    {
        private readonly ArmDbContext _armDbContext;

        public FriendRepository(ArmDbContext armDbContext) 
        {
            _armDbContext = armDbContext;
        }

        public IEnumerable<Friend> GetAllFriends() => _armDbContext.Friends.Select(f => new Friend
        {
            Id = f.Id,
            FirstName = f.FirstName,
            LastName = f.LastName,
            Email = f.Email,
            Phone = f.Phone,
            Address = f.Address
        });

        public Friend GetFriendById(int userId)
        {
            // Check if given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            return new Friend
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
            // check if we have connection in db if not set Id to 1 else find the highest Id and add 1 to it
            int nextInt = 0;
            if(_armDbContext.Friends.Count() == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _armDbContext.Friends.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
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

            _armDbContext.Friends.Add(entity);
            _armDbContext.SaveChanges();
            
            return entity;
        }
        public Friend UpdateFriendById(int userId, FriendUpdateInputModel body)
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            
            friend.FirstName = string.IsNullOrEmpty(body.FirstName) ? friend.FirstName : body.FirstName;
            friend.LastName = string.IsNullOrEmpty(body.LastName) ? friend.LastName : body.LastName;
            friend.Email = string.IsNullOrEmpty(body.Email) ? friend.Email : body.Email;
            friend.Phone = string.IsNullOrEmpty(body.Phone) ? friend.Phone : body.Phone;
            friend.Address = string.IsNullOrEmpty(body.Address) ? friend.Address : body.Address;
            _armDbContext.SaveChanges();

            return friend;
        }
        public Friend DeleteFriendById(int userId)
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }

            _armDbContext.Remove(friend);
            _armDbContext.SaveChanges();

            return friend;
        }

        public IEnumerable<Publication> GetRecommendations(int userId)
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} was not found");
            }

            // Get list of publications from list of loans via join
            var userPublications = _armDbContext.PublicationsToFriend
                                    .Where(p2f => p2f.FriendId == userId)
                                    .Join(_armDbContext.Publications, 
                                            p => p.PublicationId, 
                                            pub => pub.Id,
                                            (outer, inner) => inner);

            // First, get all publications EXCEPT those that have been borrowed to user
            // Then, order by estimated average review score
            var recommendations =  _armDbContext.Publications
                                    .Except(userPublications)
                                    .OrderByDescending(pub => pub.Rating);

            return recommendations;
        }
    }
}