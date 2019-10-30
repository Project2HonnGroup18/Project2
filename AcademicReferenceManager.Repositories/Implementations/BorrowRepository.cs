using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly ArmDbContext _armDbContext;

        public BorrowRepository(ArmDbContext armDbContext) 
        {
            _armDbContext = armDbContext;
        }
        public IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections() => 
                    _armDbContext.PublicationsToFriend.Select(p => new PublicationToFriendDto
                    {
                        Id = p.Id,
                        FriendId = p.FriendId,
                        PublicationId = p.PublicationId,
                        BorrowDate = p.BorrowDate,
                        ReturnDate = p.ReturnDate
                    });
        public PublicationToFriendDto GetBorrowConnectionById(int connectionID)
        {
            var connection = _armDbContext.PublicationsToFriend.FirstOrDefault(p => p.Id == connectionID);
            if(connection == null)
            {
                throw new ResourceNotFoundException($"Borrow connection with id: {connection.Id} was not found");
            }
            return new PublicationToFriendDto
            {
                Id = connection.Id,
                FriendId = connection.FriendId,
                PublicationId = connection.PublicationId,
                BorrowDate = connection.BorrowDate,
                ReturnDate = connection.ReturnDate
            };
        }

        public PublicationToFriend CreateFriendBorrowsABookConnection(PublicationToFriendInputModel body) 
        {
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == body.FriendId);
            if(friend == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {body.FriendId} was not found");
            }

            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == body.PublicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {body.PublicationId} was not found");
            }

            bool alreadyBorrowed = _armDbContext.PublicationsToFriend.Any(p => p.FriendId == friend.Id && p.PublicationId == publication.Id);
            if(alreadyBorrowed)
            {
                throw new ModelFormatException($"Friend: {friend.FirstName} has already borrowed {publication.Title}");
            }

            int nextInt = 0;
            if(_armDbContext.PublicationsToFriend.Count() == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _armDbContext.PublicationsToFriend.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            }

            var entity = new PublicationToFriend
            {
                Id = nextInt,
                FriendId = body.FriendId,
                PublicationId = body.PublicationId,
                BorrowDate = body.BorrowDate,
                ReturnDate = body.ReturnDate
            };

            _armDbContext.PublicationsToFriend.Add(entity);
            _armDbContext.SaveChanges();
            return entity;
        }

        public IEnumerable<FriendThatBorrowedPublicationDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime date) 
        {
            var connection = _armDbContext.PublicationsToFriend;
            List<FriendThatBorrowedPublicationDto> returnList = new List<FriendThatBorrowedPublicationDto>();
            foreach(PublicationToFriend p2f in _armDbContext.PublicationsToFriend) 
            {
                if(p2f.BorrowDate == date)
                {
                   var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                   var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == p2f.PublicationId);
                   returnList.Add(new FriendThatBorrowedPublicationDto
                   {
                       FriendFirstName = friend.FirstName,
                       FriendLastName = friend.LastName,
                       FriendPhone = friend.Phone,
                       PublicationTitle = publication.Title
                   });
                }
            }
            return returnList;
        }
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(DateTime date)
        {
            List<FriendDto> returnList = new List<FriendDto>();
            foreach(PublicationToFriend p2f in _armDbContext.PublicationsToFriend) 
            {
                if(p2f.BorrowDate != null && p2f.ReturnDate != null)
                {
                    var borrowDate = (DateTime)p2f.BorrowDate;
                    var returnDate = (DateTime)p2f.ReturnDate;
                    if(p2f.BorrowDate < date && p2f.ReturnDate > date)
                    {
                        var check = Math.Floor(((borrowDate.Year - returnDate.Year) * 12.0)
                            + borrowDate.Month - returnDate.Month);
                        if(check != 0)
                        {
                            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                            returnList.Add( new FriendDto
                            {
                                Id = friend.Id,
                                FirstName = friend.FirstName,
                                LastName = friend.LastName,
                                Email = friend.Email,
                                Address = friend.Address
                            });
                        }
                    }
                }
            }
            return returnList;
        }
        
        public IEnumerable<PublicationBorrowedByFriendDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date)
        {
            var borrows = _armDbContext.PublicationsToFriend.Include(p => p.Publication).Include(f => f.Friend); 
            List<PublicationBorrowedByFriendDto> returnList = new List<PublicationBorrowedByFriendDto>();
            foreach(PublicationToFriend p2f in borrows)
            {
                if(p2f.BorrowDate < date && p2f.ReturnDate > date)
                {
                    var publication = p2f.Publication; 
                    var friend = p2f.Friend;
                    returnList.Add( new PublicationBorrowedByFriendDto
                    {
                        EditorFirstName = publication.EditorFirstName,
                        EditorLastName = publication.EditorLastName,
                        PublicationTitle = publication.Title,
                        PublicationYear = publication.Year,
                        PublicationType = publication.Type,
                        PublicationIsbn = publication.Isbn,
                        FriendFirstName = friend.FirstName,
                        FriendLastName = friend.LastName,
                        FriendPhone = friend.Phone
                    });
                }
            }
            return returnList;
        }
    }
}