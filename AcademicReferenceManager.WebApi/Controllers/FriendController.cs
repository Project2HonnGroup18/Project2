using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        private readonly IFriendService _friendService;
        private readonly IReviewService _reviewService;
        public FriendController(IFriendService friendService, IReviewService reviewService)
        {
            _friendService = friendService;
            _reviewService = reviewService;
        }

        [HttpGet]
        [Route("", Name = "GetAllFriends")]
        public IActionResult GetAllFriends()
        {
            var friends = _friendService.GetAllFriends();
            return Ok(friends);
        }

        [HttpGet]
        [Route("{userId:int}", Name = "GetFriendById")]
        public IActionResult GetFriendByID(int userId)
        {
            var friend = _friendService.GetFriendById(userId);
            return Ok(friend);
        }

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

        [HttpPut]
        [Route("{userId:int}", Name = "UpdateFriendById")]
        public IActionResult UpdateFriendById(int userId, [FromBody] FriendUpdateInputModel body) 
        {
            var friend = _friendService.UpdateFriendById(userId, body);
            return Ok(friend);
        }

        [HttpDelete]
        [Route("{userId:int}", Name = "DeleteFriendById")]
        public IActionResult DeleteFriendById(int userId) 
        {
            var friend = _friendService.DeleteFriendById(userId);
            return Ok(friend);
        }

        [HttpGet]
        [Route("{friendId:int}/reviews", Name = "GetReviewsByGivenUser")]

        public IActionResult GetReviewsByUser(int friendId) 
        {
            var reviews = _reviewService.GetReviewsByUser(friendId);
            return Ok(reviews);
        }

        [HttpPost]
        [Route("{userId:int}/reviews/{publicationId:int}", Name = "AddUserReviewForPublication")]

        public IActionResult AddUserReviewForPublication(int userId, int publicationId, [FromBody] ReviewInputModel body) 
        {  
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var entity = _reviewService.AddUserReviewForPublication(userId, publicationId, body);
            return CreatedAtRoute("GetReviewsByGivenUser", new { userId = entity.FriendId, publicationId = entity.PublicationId }, null);

        }
    }
}