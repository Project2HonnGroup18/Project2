using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface IPublicationService
    {
        IEnumerable<PublicationDto> GetAllPublications(DateTime? loanDate);
        PublicationDto GetPublicationById(int publicationId);
        PublicationDto CreatePublication(PublicationInputModel body);
        PublicationDto UpdatePublicationById(int publicationId, PublicationUpdateInputModel body);
        PublicationDto DeletePublicationById(int publicationId);
    }
}