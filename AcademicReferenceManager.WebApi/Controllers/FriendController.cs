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
        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
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
    }
}