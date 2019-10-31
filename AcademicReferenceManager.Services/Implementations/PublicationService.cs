using System;
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
        private readonly IBorrowRepository _borrowRepo;

        public PublicationService(IPublicationRepository publicationRepo, IBorrowRepository borrowRepo)
        {
            _publicationRepo = publicationRepo;
            _borrowRepo = borrowRepo;
        }

        public IEnumerable<PublicationDto> GetAllPublications(DateTime? loanDate) 
        {
            if(loanDate.HasValue)
            {
                return _borrowRepo.GetAllPublicationsThatAreOnLoanByParticularDate(loanDate);
            }
            else 
            {
                return _publicationRepo.GetAllPublications();
            }
        }
        public PublicationDto GetPublicationById(int publicationId) => _publicationRepo.GetPublicationById(publicationId);
        public Publication CreatePublication(PublicationInputModel body) => _publicationRepo.CreatePublication(body);
        public Publication UpdatePublicationById(int publicationId, PublicationUpdateInputModel body) => _publicationRepo.UpdatePublicationById(publicationId, body);
        public Publication DeletePublicationById(int publicationId) => _publicationRepo.DeletePublicationById(publicationId);
    }
}