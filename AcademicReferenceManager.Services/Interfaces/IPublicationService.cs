using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IPublicationService
    {
        IEnumerable<PublicationDto> GetAllPublications();
        PublicationDto GetPublicationById(int publicationId);
        Publication CreatePublication(PublicationInputModel body);
    }
}