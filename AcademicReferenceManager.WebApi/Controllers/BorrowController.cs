using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/borrow")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IBorrowService _borrowService;

        public BorrowController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }
    
        [HttpGet]
        [Route("", Name = "GetAllFriendBorrowsABookConnections")]
        public IActionResult GetAllFriendBorrowsABookConnections()
        {
            var connections = _borrowService.GetAllFriendBorrowsABookConnections();
            return Ok(connections);
        }

        [HttpGet]
        [Route("{connectionId:int}", Name = "GetBorrowConnectionById")]
        public IActionResult GetBorrowConnectionById(int connectionId)
        {
            var connection = _borrowService.GetBorrowConnectionById(connectionId);
            return Ok(connection);
        }

        [HttpGet]
        [Route("friend-that-borrowed-publications/{date}")]
        public IActionResult GetAllFriendsThatBorrowedPublicationsByParticularDate(string date)
        {
            DateTime converter = DateTime.Parse(date);
            return Ok(_borrowService.GetAllFriendsThatBorrowedPublicationsByParticularDate(converter));
        } 

        [HttpGet]
        [Route("borrowed-for-longer-than-month/{date}")]
        public IActionResult GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(string date)
        {
            DateTime converter = DateTime.Parse(date);
            return Ok(_borrowService.GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(converter));
        }

        [HttpGet]
        [Route("publication-on-loan/{date}")]
        public IActionResult GetAllPublicationsThatAreOnLoanByParticularDate(String date)
        {
            DateTime converter = DateTime.Parse(date);
            return Ok(_borrowService.GetAllPublicationsThatAreOnLoanByParticularDate(converter));
        }
    }

}