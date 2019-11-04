using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Implementations;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using UnitTests.ServiceStubs;
using Xunit;

namespace UnitTests
{
    public class PublicationControllerTests
    {
        PublicationController _controller;
        IPublicationService _publicationService;
        IReviewService _reviewService;
        

        public PublicationControllerTests()
        {
            _publicationService = new PublicationServiceStub();
            _reviewService = new ReviewServiceStub();
            _controller = new PublicationController(_publicationService, _reviewService);
        }

        [Fact]
        public void GetAllPublications_WhenCalled_ReturnsOkResult()
        {
            //DateTime loanDate = new DateTime(2019, 1, 1);

            

            // Act
            var okResult = _controller.GetAllPublications(null);
 
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void GetPublicationById_WhenCalled_ReturnsOkResult()
        {
    
            // Act
            var okResult = _controller.GetPublicationById(1);
            
            // Assert
            var result = Assert.IsType<OkObjectResult>(okResult);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public void CreatePublication_WhenCreatedCorrectly_ReturnsCreatedResult()
        {
            var publication = new PublicationInputModel()
            {
                EditorFirstName = "Egill",
                EditorLastName = "Joh",
                Title = "Gillis pub",
                Journal = "World scientific",
                Isbn = "123456-1234",
                Year = 2019,
                Type = "electronic"
                
            };
            var createdResult = _controller.CreatePublication(publication);

            var result = Assert.IsType<CreatedAtRouteResult>(createdResult);
            Assert.Equal(201, result.StatusCode);
        }

    }
}