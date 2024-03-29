using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class BorrowRepository : IBorrowRepository
    {
        private readonly ArmDbContext _armDbContext;

        public BorrowRepository(ArmDbContext armDbContext) 
        {
            _armDbContext = armDbContext;
        }
        public IEnumerable<Friend> GetAllFriendsThatHaveAPublicationOnLoanByParticularDate(DateTime date) 
        {
            var connection = _armDbContext.PublicationsToFriend.ToList();
            List<Friend> friends = new List<Friend>();

            // for each loan connection see if it was on loan on a given date - return those who are as a friend view model
            foreach(PublicationToFriend p2f in connection) 
            {
                var retDate = p2f.ReturnDate == null ? DateTime.Now : p2f.ReturnDate;
                if(p2f.BorrowDate <= date && retDate > date)
                {
                   var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                   friends.Add(new Friend

                   {
                       Id = friend.Id,
                       FirstName = friend.FirstName,
                       LastName = friend.LastName,
                       Email = friend.Email,
                       Phone = friend.Phone,
                       Address = friend.Address
                   });
                }
            }
            return friends;
        }
        public IEnumerable<Friend> GetAllFriendsThatBorrowedForLongerThanParticularDuration(int loanDuration)
        {
            var connections = _armDbContext.PublicationsToFriend.ToList();
            List<Friend> friends = new List<Friend>();

            // foreach connection check if return is null or larger then date time now = still on loan.
            // Create timespan and subtract date time now to see the time between borrow date and now.
            // Then check if number of days on that timespan is larger or equal to given loanduration - return those who are.
            foreach(PublicationToFriend p2f in connections) 
            {
                if(p2f.BorrowDate != null && (p2f.ReturnDate == null || p2f.ReturnDate > DateTime.Now))
                {
                    var borrowDate = (DateTime)p2f.BorrowDate;
                    TimeSpan ts = DateTime.Now.Subtract(borrowDate);

                    int NumberOfDays = (int) ts.TotalDays;
                    if(NumberOfDays >= loanDuration)
                    {
                        var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                        friends.Add( new Friend
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
            return friends;
        }

        public IEnumerable<Publication> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date)
        {
            var borrows = _armDbContext.PublicationsToFriend.ToList();
            List<Publication> publications = new List<Publication>();
            // for each loan connection see if it was on loan on a given date - return those who are as a publication view model
            foreach(PublicationToFriend p2f in borrows)
            {
                var retDate = p2f.ReturnDate == null ? DateTime.Now : p2f.ReturnDate;
                if(p2f.BorrowDate < date && retDate > date)
                {
                    var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == p2f.PublicationId);
                    publications.Add(new Publication
                    {
                        Id = publication.Id,
                        EditorFirstName = publication.EditorFirstName,
                        EditorLastName = publication.EditorLastName,
                        Title = publication.Title,
                        Year = publication.Year,
                        Type = publication.Type,
                        Isbn = publication.Isbn
                    });
                }
            }
            return publications;
        }

        public IEnumerable<Friend> GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(DateTime loanDate, int loanDuration)
        {
            var connections = _armDbContext.PublicationsToFriend.ToList();
            List<Friend> returnList = new List<Friend>();

            // foreach connection check if return is null or larger then date time now = still on loan.
            // Create timespan and subtract date time now to see the time between borrow date and now.
            // Then check if number of days on that timespan is larger or equal to given loanduration.
            // Covering those who are already on loan
            // For those who have been returned
            // create another timespan subtract the return date from the borrow date and check same condition with that time span
            // Then check if number of days on that timespan is larger or equal to given loanduration. - return those who are
            foreach(PublicationToFriend p2f in connections) 
            {
                if(p2f.BorrowDate != null)
                {
                    var borrowDate = (DateTime)p2f.BorrowDate;

                    TimeSpan tsNow = DateTime.Now.Subtract(borrowDate);
                    int NumberOfDaysForNow = (int) tsNow.TotalDays;

                    if(p2f.BorrowDate <= loanDate && (p2f.ReturnDate >= loanDate || p2f.ReturnDate == null))
                    {
                        TimeSpan tsReturnDate = loanDate.Subtract(borrowDate);
                        int numberOfDaysForReturnDate = (int) tsReturnDate.TotalDays;
                        if(numberOfDaysForReturnDate >= loanDuration)
                        {
                            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                            returnList.Add( new Friend
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

        public IEnumerable<Publication> GetAllPublicationsAUserHasOnLoanById(int userId)
        {
            // Validate that given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }

            var connections = _armDbContext.PublicationsToFriend.Where(f => f.FriendId == userId);
            List<Publication> publications = new List<Publication>();
            // Foreach connection check if the publication has been returned 
            // - Return those who have not been returned as a publication view model
            foreach(PublicationToFriend p2f in connections)
            {
                if(p2f.ReturnDate == null || p2f.ReturnDate < DateTime.Now)
                {
                    var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == p2f.PublicationId);
                    publications.Add(new Publication
                    {
                        Id = publication.Id,
                        EditorFirstName = publication.EditorFirstName,
                        EditorLastName = publication.EditorLastName,
                        Title = publication.Title,
                        Year = publication.Year,
                        Type = publication.Type,
                        Isbn = publication.Isbn
                    });
                }
            }
            return publications;
        }
        public PublicationToFriend CreateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body) 
        {
            // Check if given user exists
            var friend = _armDbContext.Friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null)
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            // Check if given publication exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }
            // check if given user has allready borrowed given publication
            bool alreadyBorrowed = _armDbContext.PublicationsToFriend.Any(p => p.FriendId == friend.Id && p.PublicationId == publication.Id);
            if(alreadyBorrowed)
            {
                throw new ModelFormatException($"User with id: {userId} has already borrowed publication with id: {publicationId}");
            }

            // check if we have connection in db if not set Id to 1 else find the highest Id and add 1 to it
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
                FriendId = userId,
                PublicationId = publicationId,
                BorrowDate = body.BorrowDate.HasValue ? body.BorrowDate : DateTime.Now,
                ReturnDate = body.ReturnDate
            };

            _armDbContext.PublicationsToFriend.Add(entity);
            _armDbContext.SaveChanges();
            return entity;
        }
        public PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body)
        {
            // Check if given user has allready borrowed given publication
            var connection = _armDbContext.PublicationsToFriend.FirstOrDefault(c => c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} has not borrowed book with id: {publicationId}");
            }
            
            connection.BorrowDate = body.BorrowDate;
            connection.ReturnDate = body.ReturnDate;
            _armDbContext.SaveChanges();

            return connection;
        }
        public PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId)
        {
            // Check if given user has allready borrowed given publication
            var connection = _armDbContext.PublicationsToFriend.FirstOrDefault(c => c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} has not borrowed book with id: {publicationId}");
            }

            _armDbContext.Remove(connection);
            _armDbContext.SaveChanges();

            return connection;
        }
    }
}