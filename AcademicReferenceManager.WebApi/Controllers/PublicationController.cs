using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
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

        [HttpGet]
        [Route("", Name = "GetAllPublications")]
        public IActionResult GetAllPublications()
        {
            var publications = _publicationService.GetAllPublications();
            return Ok(publications);
        }

        [HttpGet]
        [Route("{publication_id:int}", Name = "GetPublicationById")]
        public IActionResult GetPublicationById(int publication_id)
        {
            var publication = _publicationService.GetPublicationById(publication_id);
            return Ok(publication);
        }

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

        [HttpPut]
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
        [Route("reviews")]
        public IActionResult GetAllReviewsForAllPublications()
        {
            var reviews = _reviewService.GetAllReviewsForAllPublications();
            return Ok(reviews);
        }
    }
}