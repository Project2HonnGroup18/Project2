using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IPublicationRepository
    {
        IEnumerable<PublicationDto> GetAllPublications();
        PublicationDto GetPublicationById(int publicationId);
        Publication CreatePublication(PublicationInputModel body);
        Publication UpdatePublicationById(int publicationId, PublicationUpdateInputModel body);
        Publication DeletePublicationById(int publicationId);
    }
}