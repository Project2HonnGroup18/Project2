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
    public class BorrowRepository : IBorrowRepository
    {

        private readonly IFriendDbContext _friendDbContext;
        private readonly IPublicationDbContext _publicationDbContext;
        private readonly IPublicationToFriendDbContext _publicationToFriendDbContext;

        public BorrowRepository(IFriendDbContext fDbContext, IPublicationDbContext pDbContext,IPublicationToFriendDbContext ptfDbContext) 
        {
            _friendDbContext = fDbContext;
            _publicationToFriendDbContext = ptfDbContext;
            _publicationDbContext = pDbContext;
        }
        public IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections() => 
                    _publicationToFriendDbContext.PublicationsToFriend.Select(p => new PublicationToFriendDto
                    {
                        Id = p.Id,
                        FriendId = p.FriendId,
                        PublicationId = p.PublicationId,
                        BorrowDate = p.BorrowDate,
                        ReturnDate = p.ReturnDate
                    });
        public PublicationToFriendDto GetBorrowConnectionById(int connectionID)
        {
            var connection = _publicationToFriendDbContext.PublicationsToFriend.FirstOrDefault(p => p.Id == connectionID);
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
            var friend = _friendDbContext.Friends.FirstOrDefault(f => f.Id == body.FriendId);
            if(friend == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {body.FriendId} was not found");
            }

            var publication = _publicationDbContext.Publications.FirstOrDefault(p => p.Id == body.PublicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {body.PublicationId} was not found");
            }

            bool alreadyBorrowed = _publicationToFriendDbContext.PublicationsToFriend.Any(p => p.FriendId == friend.Id && p.PublicationId == publication.Id);
            if(alreadyBorrowed)
            {
                throw new ModelFormatException($"Friend: {friend.FirstName} has already borrowed {publication.Title}");
            }

            int nextInt = 0;
            if(_publicationToFriendDbContext.PublicationsToFriend.Count == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _publicationToFriendDbContext.PublicationsToFriend.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            }

            var entity = new PublicationToFriend
            {
                Id = nextInt,
                FriendId = body.FriendId,
                PublicationId = body.PublicationId,
                BorrowDate = body.BorrowDate,
                ReturnDate = body.ReturnDate
            };

            _publicationToFriendDbContext.PublicationsToFriend.Add(entity);
            return entity;
        }

        public IEnumerable<FriendThatBorrowedPublicationDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime date) 
        {
            var connection = _publicationToFriendDbContext.PublicationsToFriend;
            List<FriendThatBorrowedPublicationDto> returnList = new List<FriendThatBorrowedPublicationDto>();
            for(int i = 0; i < connection.Count(); i++) 
            {
                if(connection[i].BorrowDate == date)
                {
                   var friend = _friendDbContext.Friends.FirstOrDefault(f => f.Id == connection[i].FriendId);
                   var publication = _publicationDbContext.Publications.FirstOrDefault(p => p.Id == connection[i].PublicationId);
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
            var connection = _publicationToFriendDbContext.PublicationsToFriend;
            List<FriendDto> returnList = new List<FriendDto>();
            for(int i = 0; i < connection.Count(); i++) 
            {
                if(connection[i].BorrowDate < date && connection[i].ReturnDate > date)
                {
                    var check = Math.Floor(((connection[i].BorrowDate.Year - connection[i].ReturnDate.Year) * 12.0)
                         + connection[i].BorrowDate.Month - connection[i].ReturnDate.Month);
                    if(check != 0)
                    {
                        var friend = _friendDbContext.Friends.FirstOrDefault(f => f.Id == connection[i].FriendId);
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
            return returnList;
        }
        
        public IEnumerable<PublicationBorrowedByFriendDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date)
        {
            var connection = _publicationToFriendDbContext.PublicationsToFriend;
            List<PublicationBorrowedByFriendDto> returnList = new List<PublicationBorrowedByFriendDto>();
            for(int i = 0; i < connection.Count(); i++)
            {
                if(connection[i].BorrowDate < date && connection[i].ReturnDate > date)
                {
                    var publication = _publicationDbContext.Publications.FirstOrDefault(p => p.Id == connection[i].PublicationId); 
                    var friend = _friendDbContext.Friends.FirstOrDefault(f => f.Id == connection[i].FriendId);
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