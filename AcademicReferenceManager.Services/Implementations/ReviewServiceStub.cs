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
    public class ReviewServiceStub : IReviewService
    {
        private readonly List<Review> _reviews;
        private readonly List<Publication> _publications;
        private readonly List<Friend> _friends;
        private readonly List<PublicationToFriend> _borrows;
        
        public ReviewServiceStub()
        {
            _reviews = new List<Review>()
            {
                new Review()
                {
                    Rating = 4,
                    FriendId = 1,
                    PublicationId = 1
                },
                new Review()
                {
                    Rating = 3,
                    FriendId = 2,
                    PublicationId = 2
                },
                new Review()
                {
                    Rating = 5,
                    FriendId = 2,
                    PublicationId = 1
                },

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
                },

                new Publication()
                {
                    Id = 2,
                    EditorFirstName = "John",
                    EditorLastName = "Smith",
                    Title = "Johns pub",
                    Journal = "World Scientific",
                    Isbn = "124612345-0",
                    Year = 2019,
                    Type = "printed"
                },

                new Publication()
                {
                    Id = 3,
                    EditorFirstName = "Frank",
                    EditorLastName = "Miller",
                    Title = "Frankies pub",
                    Journal = "World Scientific",
                    Isbn = "124612345-0",
                    Year = 2019,
                    Type = "electronic"
                }
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

        }
        public IEnumerable<ReviewDto> GetReviewsByUser(int userId) 
        {
            var friend = _friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null)
            {
                throw new ResourceNotFoundException($"user with id {userId} was not found");
            }
            var reviewSet =  _reviews;
            var filtered = reviewSet.Where(f => userId == f.FriendId);
            var remapped = filtered.Select(r => new ReviewDto
            {
                Rating = r.Rating,
                PublicationId = r.PublicationId,
                FriendId = r.FriendId
            });

            return remapped;
        } 

        public ReviewDto GetUserReviewForPublication(int userId, int publicationId)
        {
            var review = _reviews
                .FirstOrDefault(f => userId == f.FriendId && publicationId == f.PublicationId);
            if(review == null)
            {
                throw new ResourceNotFoundException($"User with id: {userId} has not reviewd publication with id: {publicationId}");
            }
            var reviewDto = new ReviewDto {
                    Rating = review.Rating,
                    PublicationId = review.PublicationId,
                    FriendId = review.FriendId
            };

            return reviewDto;
        }

        public ReviewDto AddUserReviewForPublication(int userId, int publicationId, ReviewInputModel body)
        {
            // Validate that given user exists
            var friend = _friends.FirstOrDefault(f => f.Id == userId);
            if(friend == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            // Validate that given publication exists
            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }
            // Validate that given user has borrowed given publication
            var connection = _borrows.FirstOrDefault(c => 
                                c.FriendId == userId && c.PublicationId == publicationId);
            if(connection == null) 
            {
                throw new UserHasNotBorrowedBookException($"User with id: {userId} has not borrowed publication with id: {publicationId} and therefor cannot review it");
            }
            var review = new Review {
                Rating = body.Rating,
                FriendId = userId,
                PublicationId = publicationId
            };

            _reviews.Add(review);
            
            return new ReviewDto()
            {
                Rating = review.Rating
            };
        }

        public IEnumerable<PublicationReviewsDto> GetAllReviewsForAllPublications() 
        {
            var publications = _publications.ToList();
            List<PublicationReviewsDto> publicationReviews = new List<PublicationReviewsDto>();

            foreach(Publication p in publications)
            {
                var reviews = _reviews.Where(r => r.PublicationId == p.Id).Select(rdto => new ReviewDto 
                {
                    FriendId = rdto.FriendId,
                    PublicationId = rdto.PublicationId,
                    Rating = rdto.Rating
                });
                publicationReviews.Add(new PublicationReviewsDto 
                {
                    Id = p.Id,
                    EditorFirstName = p.EditorFirstName,
                    EditorLastName = p.EditorLastName,
                    Title = p.Title,
                    Reviews = reviews
                });
            }

            return publicationReviews;
        }

        public ReviewDto DeleteReview(int userId, int publicationId) 
        {
            var review = _reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
            if(review == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }

            _reviews.Remove(review);
            

            return new ReviewDto()
            {
                Rating = review.Rating
            };
        }
        public ReviewDto UpdateReview(int userId, int publicationId, ReviewInputModel body) 
        {
            var review = _reviews.FirstOrDefault(f => f.FriendId == userId && f.PublicationId == publicationId);
             
            if(review == null) 
            {
                throw new ResourceNotFoundException($"Review from user with id: {userId} on publication with id: {publicationId} was not found");//($"Friend with id: {userId} was not found");
            }
            
            review.Rating = body.Rating;
                   
            return new ReviewDto()
            {
                Rating = review.Rating
            };
            
        }
        
        public PublicationReviewsDto GetAllReviewsByPublicationId(int publicationId)
        {
            // Validate that given publication exists
            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }

            // Find all reviews for given publication
            var reviews = _reviews.Where(r => r.PublicationId == publicationId).Select(rdto => new ReviewDto 
                {
                    FriendId = rdto.FriendId,
                    PublicationId = rdto.PublicationId,
                    Rating = rdto.Rating
                });

            return new PublicationReviewsDto {
                Id = publicationId,
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Reviews = reviews
            };

        }
        public ReviewDto GetAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input - Return and return the review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }
        public ReviewDto UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, ReviewInputModel body)
        {
            // Validate input and update review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            review.Rating = body.Rating;
            

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }
        public ReviewDto DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Validate input and remove review
            var review = ValidateInputsForAReviewForASpecificPublicationByUserId(publicationId, userId);
            _reviews.Remove(review);

            return new ReviewDto
            {
                FriendId = review.FriendId,
                PublicationId = review.PublicationId,
                Rating = review.Rating
            };
        }

        //********************
        //* Helper functions *
        //********************
        private Review ValidateInputsForAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            // Check if publication with given publication id exists
            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }

            // Check if user with given user id exists
            var user = _friends.FirstOrDefault(f => f.Id == userId);
            if(user == null) 
            {
                throw new ResourceNotFoundException($"User with id: {userId} was not found");
            }
            
            // Validate that given user has reviewed given publication
            var review = _reviews.FirstOrDefault(r => r.PublicationId == publicationId && r.FriendId == userId);
            if(review == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} has not been reviewd by user with id {userId}");
            }

            return review;
        }
    }
    
}