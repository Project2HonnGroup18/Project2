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
    public class BorrowServiceStub : IBorrowService
    {
        private readonly List<PublicationToFriend> _borrows;
        private readonly List<Friend> _friends;
        private readonly List<Publication> _publications;
        public BorrowServiceStub()
        {
            _borrows = new List<PublicationToFriend>()
            {
                new PublicationToFriend()
                {
                    Id = 1,
                    BorrowDate = new DateTime(2019, 1, 1),
                    ReturnDate = new DateTime(2019, 2, 1),
                    PublicationId = 1,
                    FriendId = 1,

                },
                new PublicationToFriend()
                {
                    Id = 2,
                    BorrowDate = new DateTime(2019, 4, 10),
                    ReturnDate = new DateTime(2019, 6, 10),
                    PublicationId = 2,
                    FriendId = 1,
                    
                },
                new PublicationToFriend()
                {
                    Id = 3,
                    BorrowDate = new DateTime(2019, 7, 15),
                    ReturnDate = new DateTime(2019, 8, 15),
                    PublicationId = 3,
                    FriendId = 1,
                   
                },

            };

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
                }
            };

            _publications = new List<Publication>()
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

        public IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections()
        {
            var borrow = _borrows.Select(p => new PublicationToFriendDto
            {
                Id = p.Id,
                FriendId = p.FriendId,
                PublicationId = p.PublicationId,
                BorrowDate = p.BorrowDate,
                ReturnDate = p.ReturnDate
            });
            return borrow;
        }
                    
        public PublicationToFriendDto GetBorrowConnectionById(int connectionID)
        {
            var connection = _borrows.FirstOrDefault(p => p.Id == connectionID);
            return new PublicationToFriendDto
            {
                Id = connection.Id,
                FriendId = connection.FriendId,
                PublicationId = connection.PublicationId,
                BorrowDate = connection.BorrowDate,
                ReturnDate = connection.ReturnDate
            };
        }

        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime? date) 
        {
            var connection = _borrows.ToList();
            List<FriendDto> friends = new List<FriendDto>();
            foreach(PublicationToFriend p2f in connection) 
            {
                if(p2f.BorrowDate < date && p2f.ReturnDate > date)
                {
                   var friend = _friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                   friends.Add(new FriendDto
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
        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDuration(int? loanDuration)
        {
            var connections = _borrows.ToList();
            List<FriendDto> friends = new List<FriendDto>();
            foreach(PublicationToFriend p2f in connections) 
            {
                if(p2f.BorrowDate != null && (p2f.ReturnDate == null || p2f.ReturnDate > DateTime.Now))
                {
                    var borrowDate = (DateTime)p2f.BorrowDate;
                    TimeSpan ts = DateTime.Now.Subtract(borrowDate);

                    int NumberOfDays = (int) ts.TotalDays;
                    if(NumberOfDays >= loanDuration)
                    {
                        var friend = _friends.FirstOrDefault(f => f.Id == p2f.FriendId);
                        friends.Add( new FriendDto
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

        public IEnumerable<PublicationDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime? date)
        {
            var borrows = _borrows.ToList();
            List<PublicationDto> publications = new List<PublicationDto>();
            foreach(PublicationToFriend p2f in borrows)
            {
                if(p2f.BorrowDate < date && p2f.ReturnDate > date)
                {
                    var publication = _publications.FirstOrDefault(p => p.Id == p2f.PublicationId);
                    publications.Add(new PublicationDto
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

        public IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanParticularDaysByParticularDate(DateTime? loanDate, int? loanDuration)
        {
            var connections = _borrows.ToList();
            List<FriendDto> returnList = new List<FriendDto>();
            foreach(PublicationToFriend p2f in connections) 
            {
                if(p2f.BorrowDate != null)
                {
                    var borrowDate = (DateTime)p2f.BorrowDate;
                    var returnDate = (DateTime)p2f.ReturnDate;

                    TimeSpan tsNow = DateTime.Now.Subtract(borrowDate);
                    int NumberOfDaysForNow = (int) tsNow.TotalDays;

                    TimeSpan tsReturnDate = returnDate.Subtract(borrowDate);
                    int NumberOfDaysForReturnDate = (int) tsReturnDate.TotalDays;

                    bool conditionsMet = false;

                    if(returnDate == null || returnDate > DateTime.Now)
                    {
                        conditionsMet = NumberOfDaysForNow >= loanDuration ? true : false;
                    }
                    else
                    {
                        conditionsMet = NumberOfDaysForReturnDate >= loanDuration ? true : false;

                    }
                    if(conditionsMet)
                    {
                        var friend = _friends.FirstOrDefault(f => f.Id == p2f.FriendId);
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

        public IEnumerable<PublicationDto> GetAllPublicationsAUserHasOnLoanById(int userId)
        {
            var friend = _friends.FirstOrDefault(f => f.Id == userId);
            

            var connections = _borrows.Where(f => f.FriendId == userId);
            List<PublicationDto> publications = new List<PublicationDto>();
            foreach(PublicationToFriend p2f in connections)
            {
                if(p2f.ReturnDate == null || p2f.ReturnDate < DateTime.Now)
                {
                    var publication = _publications.FirstOrDefault(p => p.Id == p2f.PublicationId);
                    publications.Add(new PublicationDto
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
            var friend = _friends.FirstOrDefault(f => f.Id == userId);

            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            

            bool alreadyBorrowed = _borrows.Any(p => p.FriendId == friend.Id && p.PublicationId == publication.Id);
            if(alreadyBorrowed)
            {
                throw new ModelFormatException($"Friend: {friend.FirstName} has already borrowed {publication.Title}");
            }

            int nextInt = 0;
            if(_borrows.Count() == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _borrows.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            }

            var entity = new PublicationToFriend
            {
                Id = nextInt,
                FriendId = userId,
                PublicationId = publicationId,
                BorrowDate = body.BorrowDate.HasValue ? body.BorrowDate : DateTime.Now,
                ReturnDate = body.ReturnDate
            };

            _borrows.Add(entity);
            return entity;
        }
        public PublicationToFriend UpdateFriendBorrowsABookConnection(int userId, int publicationId, PublicationToFriendInputModel body)
        {
            var connection = _borrows.FirstOrDefault(c => c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} has not borrowed book with id: {publicationId}");
            }
            
            connection.BorrowDate = body.BorrowDate;
            connection.ReturnDate = body.ReturnDate;

            return connection;
        }
        public PublicationToFriend DeleteFriendBorrowsABookConnection(int userId, int publicationId)
        {
            var connection = _borrows.FirstOrDefault(c => c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null)
            {
                throw new ResourceNotFoundException($"Friend with id: {userId} has not borrowed book with id: {publicationId}");
            }

            _borrows.Remove(connection);


            return connection;
        }
    }
             
}