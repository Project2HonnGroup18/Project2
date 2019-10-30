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
        public PublicationController(IPublicationService publicationService)
        {
            _publicationService = publicationService;
        }

        // Get all publications
        [HttpGet]
        [Route("", Name = "GetAllPublications")]
        public IActionResult GetAllPublications()
        {
            var publications = _publicationService.GetAllPublications();
            return Ok(publications);
        }

        // Get publication by ID
        [HttpGet]
        [Route("{publication_id:int}", Name = "GetPublicationById")]
        public IActionResult GetPublicationById(int publication_id)
        {
            var publication = _publicationService.GetPublicationById(publication_id);
            return Ok(publication);
        }

        // Create new  publication
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

        // Update a publication
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

        // Delete a publication
        [HttpDelete]
        [Route("{publication_id:int}", Name = "DeletePublicationById")]
        public IActionResult DeletePublicationById(int publication_id)
        {
            var publication = _publicationService.DeletePublicationById(publication_id);
            return Ok(publication);
        }
    }
}