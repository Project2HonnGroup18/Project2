using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Interfaces;
using AcademicReferenceManager.Services.Interfaces;

namespace AcademicReferenceManager.Services.Implementations
{
    public class PublicationService : IPublicationService
    {
        private readonly IPublicationRepository _publicationRepo;

        public PublicationService(IPublicationRepository publicationRepo)
        {
            _publicationRepo = publicationRepo;
        }

        public IEnumerable<PublicationDto> GetAllPublications() => _publicationRepo.GetAllPublications();
        public PublicationDto GetPublicationById(int publicationId) => _publicationRepo.GetPublicationById(publicationId);
        public Publication CreatePublication(PublicationInputModel body) => _publicationRepo.CreatePublication(body);
    }
}