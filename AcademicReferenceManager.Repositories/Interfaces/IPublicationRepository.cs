using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IPublicationRepository
    {
        IEnumerable<Publication> GetAllPublications();
        Publication GetPublicationById(int publicationId);
        Publication CreatePublication(PublicationInputModel body);
        Publication UpdatePublicationById(int publicationId, PublicationUpdateInputModel body);
        Publication DeletePublicationById(int publicationId);
    }
}