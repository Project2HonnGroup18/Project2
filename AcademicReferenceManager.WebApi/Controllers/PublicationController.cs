using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using AcademicReferenceManager.WebApi.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/publications")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService _publicationService;
        private readonly IReviewService _reviewService;
        public PublicationController(IPublicationService publicationService, IReviewService reviewService)
        {
            _publicationService = publicationService;
            _reviewService = reviewService;
        }

        // *****************************
        // * FULL CRUD For Publication *
        // *****************************

        [AdminWithQueryAttributes]
        [HttpGet]
        [Route("", Name = "GetAllPublications")]
        public IActionResult GetAllPublications([FromQuery] DateTime? LoanDate)
        {
            var publications = _publicationService.GetAllPublications(LoanDate);
            return Ok(publications);
        }

        [HttpGet]
        [Route("{publication_id:int}", Name = "GetPublicationById")]
        public IActionResult GetPublicationById(int publication_id)
        {
            var publication = _publicationService.GetPublicationById(publication_id);
            return Ok(publication);
        }

        [Admin]
        [HttpPost]
        [Route("", Name = "CreatePublication")]
        public IActionResult CreatePublication([FromBody] PublicationInputModel body)
        {
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var entity = _publicationService.CreatePublication(body);
            return CreatedAtRoute("GetPublicationById", new { publicationId = entity.Id }, null);
        }

        [Admin]
        [HttpPut]
        [Route("{publication_id:int}", Name = "UpdatePublicationById")]
        public IActionResult UpdatePublicationById(int publication_id, [FromBody] PublicationUpdateInputModel body)
        {
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var publication = _publicationService.UpdatePublicationById(publication_id, body);
            return Ok(publication);
        }

        [Admin]
        [HttpDelete]
        [Route("{publication_id:int}", Name = "DeletePublicationById")]
        public IActionResult DeletePublicationById(int publication_id)
        {
            var publication = _publicationService.DeletePublicationById(publication_id);
            return Ok(publication);
        }

        // *************************************
        // * FULL CRUD For Publication reviews *
        // *************************************

        [HttpGet]
        [Route("reviews", Name = "GetAllReviewsForAllPublications")]
        public IActionResult GetAllReviewsForAllPublications()
        {
            var reviews = _reviewService.GetAllReviewsForAllPublications();
            return Ok(reviews);
        }

        [HttpGet]
        [Route("{publicationId:int}/reviews", Name = "GetAllReviewsByPublicationId")]
        public IActionResult GetAllReviewsByPublicationId(int publicationId)
        {
            var reviews = _reviewService.GetAllReviewsByPublicationId(publicationId);
            return Ok(reviews);
        }

        [HttpGet]
        [Route("{publicationId:int}/reviews/{userId:int}", Name = "GetAReviewForASpecificPublicationByUserId")]
        public IActionResult GetAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            var review = _reviewService.GetAReviewForASpecificPublicationByUserId(publicationId, userId);
            return Ok(review);
        }

        [Authenticated]
        [HttpPut]
        [Route("{publicationId:int}/reviews/{userId:int}", Name = "UpdateAReviewForASpecificPublicationByUserId")]
        public IActionResult UpdateAReviewForASpecificPublicationByUserId(int publicationId, int userId, [FromBody] ReviewInputModel body)
        {
            var review = _reviewService.UpdateAReviewForASpecificPublicationByUserId(publicationId, userId, body);
            return Ok(review);
        }

        [Authenticated]
        [HttpDelete]
        [Route("{publicationId:int}/reviews/{userId:int}", Name = "DeleteAReviewForASpecificPublicationByUserId")]
        public IActionResult DeleteAReviewForASpecificPublicationByUserId(int publicationId, int userId)
        {
            var review = _reviewService.DeleteAReviewForASpecificPublicationByUserId(publicationId, userId);
            return Ok(review);
        }
    }
}