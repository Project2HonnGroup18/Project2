using System;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AcademicReferenceManager.WebApi.Controllers
{
    [Route("api/publication")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService _publicationService;
        public PublicationController(IPublicationService publicationService)
        {
            _publicationService = publicationService;
        }


        [HttpGet]
        public IActionResult GetAllPublications()
        {
            var publications = _publicationService.GetAllPublications();
            return Ok(publications);
        }

        [HttpGet]
        [Route("{publicationId:int}", Name = "GetPublicationById")]
        public IActionResult GetPublicationById(int publicationId)
        {
            var publication = _publicationService.GetPublicationById(publicationId);
            return Ok(publication);
        }

        [HttpPost]
        [Route("", Name = "CreatePublications")]
        public IActionResult CreatePublication([FromBody] PublicationInputModel body)
        {
            if(!ModelState.IsValid)
            {
                throw new ModelFormatException("Model not properly formatted");
            }
            var entity = _publicationService.CreatePublication(body);
            return CreatedAtRoute("GetPublicationById", new { publicationId = entity.Id }, null);
        }
    }
}