using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/friend")]
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
        [Route("{friendId:int}", Name = "GetFriendById")]
        public IActionResult GetFriendByID(int friendId)
        {
            var friend = _friendService.GetFriendById(friendId);
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
            return CreatedAtRoute("GetFriendById", new { friendId = entity.Id }, null);
        }           
    }
}