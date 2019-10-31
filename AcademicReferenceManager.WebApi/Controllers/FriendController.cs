using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        private readonly IFriendService _friendService;
        private readonly IReviewService _reviewService;
        private readonly IBorrowService _borrowService;
        public FriendController(IFriendService friendService, IReviewService reviewService, IBorrowService borrowService)
        {
            _friendService = friendService;
            _reviewService = reviewService;
            _borrowService = borrowService;
        }

        // ***********************
        // * FULL CRUD For Users *
        // ***********************

        [AdminWithQueryAttributes]
        [HttpGet]
        [Route("", Name = "GetAllFriends")]
        public IActionResult GetAllFriends([FromQuery] DateTime? LoanDate = null, [FromQuery] int? LoanDuration = null)
        {
            var friends = _friendService.GetAllFriends(LoanDate, LoanDuration);
            return Ok(friends);
        }

        [HttpGet]
        [Route("{userId:int}", Name = "GetFriendById")]
        public IActionResult GetFriendByID(int userId)
        {
            var friend = _friendService.GetFriendById(userId);
            return Ok(friend);
        }

        [Admin]
        [HttpPost]
        [Route("", Name = "CreateFriend")]
        public IActionResult CreateFriend([FromBody] FriendInputModel body)
        {
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var entity = _friendService.CreateFriend(body);
            return CreatedAtRoute("GetFriendById", new { userId = entity.Id }, null);
        }

        [Admin]
        [HttpPut]
        [Route("{userId:int}", Name = "UpdateFriendById")]
        public IActionResult UpdateFriendById(int userId, [FromBody] FriendUpdateInputModel body) 
        {
            var friend = _friendService.UpdateFriendById(userId, body);
            return Ok(friend);
        }

        [Admin]
        [HttpDelete]
        [Route("{userId:int}", Name = "DeleteFriendById")]
        public IActionResult DeleteFriendById(int userId) 
        {
            var friend = _friendService.DeleteFriendById(userId);
            return Ok(friend);
        }

        // *************************
        // * FULL CRUD For reviews *
        // *************************

        [HttpGet]
        [Route("{userId:int}/reviews", Name = "GetReviewsByGivenUser")]
        public IActionResult GetReviewsByUser(int userId) 
        {
            var reviews = _reviewService.GetReviewsByUser(userId);
            return Ok(reviews);
        }

        [HttpGet]
        [Route("{userId:int}/reviews/{publicationId:int}", Name = "GetUserReviewsForGivenPublication")]
        public IActionResult GetUserReviewsForPublication(int userId, int publicationId)
        {
            var review = _reviewService.GetUserReviewForPublication(userId, publicationId);
            return Ok(review);
        }

        [Authenticated]
        [HttpPost]
        [Route("{userId:int}/reviews/{publicationId:int}", Name = "AddUserReviewForPublication")]
        public IActionResult AddUserReviewForPublication(int userId, int publicationId, [FromBody] ReviewInputModel body) 
        {  
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var entity = _reviewService.AddUserReviewForPublication(userId, publicationId, body);
            return CreatedAtRoute("GetReviewsByGivenUser", new { userId = entity.FriendId }, null);
        }

        [Authenticated]
        [HttpDelete]
        [Route("{userId:int}/reviews/{publicationId:int}", Name = "DeleteReview")]
        public IActionResult DeleteReview(int userId, int publicationId) 
        {
            var entity = _reviewService.DeleteReview(userId, publicationId);
            return Ok(entity);
        }

        [Authenticated]
        [HttpPut]
        [Route("{userId:int}/reviews/{publicationId:int}", Name = "UpdateReview")]
        public IActionResult UpdateReview(int userId, int publicationId, [FromBody] ReviewInputModel body)
        {
            var entity = _reviewService.UpdateReview(userId, publicationId, body);
            return Ok(entity);
        }

        // **********************************
        // * FULL CRUD For Loan connections *
        // **********************************

        [HttpGet]
        [Route("{userId:int}/publications", Name = "GetAllPublicationsAUserHasOnLoanById")]
        public IActionResult GetAllPublicationsAUserHasOnLoanById(int userId)
        {
            var publications = _borrowService.GetAllPublicationsAUserHasOnLoanById(userId);
            return Ok(publications);
        }

        [Authenticated]
        [HttpPost]
        [Route("{userId:int}/publications/{publicationId:int}", Name = "CreateFriendBorrowsABookConnection")]
        public IActionResult CreateFriendBorrowsABookConnection(int userId, int publicationId, [FromBody] PublicationToFriendInputModel body)
        {
            var entity = _borrowService.CreateFriendBorrowsABookConnection(userId, publicationId, body);
            //TODO : FIXA OK
            return Created("Ok", new { publicationId = entity.Id });
        }
        
        [Authenticated]
        [HttpPut]
        [Route("{userId:int}/publications/{publicationId:int}", Name = "UpdateFriendBorrowsABookConnection")]
        public IActionResult UpdateFriendBorrowsABookConnection(int userId, int publicationId, [FromBody] PublicationToFriendInputModel body)
        {
            var entity = _borrowService.UpdateFriendBorrowsABookConnection(userId, publicationId, body);
            return Ok(entity);
        }

        [Authenticated]
        [HttpDelete]
        [Route("{userId:int}/publications/{publicationId:int}", Name = "DeleteFriendBorrowsABookConnection")]
        public IActionResult DeleteFriendBorrowsABookConnection(int userId, int publicationId)
        {
            var entity = _borrowService.DeleteFriendBorrowsABookConnection(userId, publicationId);
            return Ok(entity);
        }

        [Authenticated]
        [HttpGet]
        [Route("{userId:int}/recommendations", Name = "GetRecommendationsForUser")]
        public IActionResult GetRecommendationsForUser(int userId)
        {
            var recommendations = _friendService.GetRecommendations(userId);
            return Ok(recommendations);
        }
    }
}