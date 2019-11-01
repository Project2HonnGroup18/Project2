using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using UnitTests.ServiceStubs;
using Xunit;

namespace UnitTests
{
    public class FriendControllerTest
    {
        FriendController _controller;
        IFriendService _friendService;
        IReviewService _reviewService;
        IBorrowService _borrowService;

        public FriendControllerTest()
        {
            _friendService = new FriendServiceStub();
            _borrowService = new BorrowServiceStub();
            _reviewService = new ReviewServiceStub();
            _controller = new FriendController(_friendService, _reviewService, _borrowService);
        }

        [Fact]
        public void GetAllFriends_WhenCalled_ReturnsOkResult()
        {
            //DateTime loanDate = new DateTime(2019, 1, 1);
            // Act
            var okResult = _controller.GetAllFriends(null, null);
            // Act
 
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void GetFriendById_WhenCalledWithExistringId_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFriendByID(1);
            
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
            
        }

        [Fact]
        public void GetFriendById_WhenCalledWithWrongId_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetFriendByID(-1000);
            if(notFoundResult == null)
            {
                // Assert
                var result = Assert.IsType<NotFoundResult>(notFoundResult);
                Assert.Equal(404, result.StatusCode);
            }
        
        
        }
    }
}