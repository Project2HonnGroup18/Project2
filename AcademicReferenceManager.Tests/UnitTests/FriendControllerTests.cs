using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi.Attributes;
using AcademicReferenceManager.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTests.ServiceStubs;
using Xunit;

namespace UnitTests
{
    public class FriendControllerTests
    {
        FriendController _controller;
        IFriendService _friendService;
        IReviewService _reviewService;
        IBorrowService _borrowService;

        public FriendControllerTests()
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
 
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void GetFriendById_WhenCalledWithExistingId_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetFriendByID(1);
            
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
            
        }

        [Fact]
        public void CreateFriend_WhenCreatedCorrectly_ReturnsCreatedResult()
        {
            var friend = new FriendInputModel()
            {
                FirstName = "Egill",
                LastName = "Joh",
                Email = "egillj17@ru.is",
                Phone = "659 0407",
                Address = "Reynimelur 47"
            };
            var createdResult = _controller.CreateFriend(friend);

            var result = Assert.IsType<CreatedAtRouteResult>(createdResult);
            Assert.Equal(201, result.StatusCode);
        }

        [Fact]
        public void UpdateFriendById_WhenUpdatedWithExistingId_ReturnsOkResult()
        {
            var friend = new FriendUpdateInputModel()
            {
                FirstName = "Lárus",
            };

            var okResult = _controller.UpdateFriendById(1, friend);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);

        }

        [Fact]
        public void DeleteFriendById_WhenDeletedWithExistingId_ReturnsOkResult()
        {

            var okResult = _controller.DeleteFriendById(1);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);

        }

        [Fact]
        public void GetReviewsByUserId_WhenCalledWithExistingId_ReturnsOkResult()
        {
            var okResult = _controller.GetReviewsByUser(3);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void GetReviewsForPublication_WhenCalledWithExistingId_ReturnsOkResult()
        {
            var okResult = _controller.GetUserReviewsForPublication(1, 1);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void AddUserReviewForPublication_WhenCalledWithExistingIds_ReturnsCreatedResult()
        {
            var review = new ReviewInputModel()
            {
                Rating = 5
            };
            var createdResult = _controller.AddUserReviewForPublication(1, 1, review);

            var result = Assert.IsType<CreatedAtRouteResult>(createdResult);
            Assert.Equal(201, result.StatusCode);
        }

        [Fact]
        public void DeleteReview_WhenDeletedWithExistingId_ReturnsOkResult()
        {

            var okResult = _controller.DeleteReview(1,1);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);

        }

        [Fact]
        public void UpdateReview_WhenUpdatesWithExistingId_ReturnsOkResult()
        {

            var review = new ReviewInputModel()
            {
                Rating = 5,
            };

            var okResult = _controller.UpdateReview(1, 1, review);

            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);

        }


    }
}