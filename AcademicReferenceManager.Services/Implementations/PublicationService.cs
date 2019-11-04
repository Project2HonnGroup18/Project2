using System;
using System.Collections.Generic;
using System.Linq;
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
            IEnumerable<Publication> pubs;
            if(loanDate.HasValue)
            {
                pubs = _borrowRepo.GetAllPublicationsThatAreOnLoanByParticularDate((DateTime) loanDate);
            }
            else 
            {
                pubs = _publicationRepo.GetAllPublications();
            }
            return pubs.Select(p => new PublicationDto(p));
        }
        public PublicationWithBorrowHistoryDto GetPublicationById(int publicationId) 
            => new PublicationWithBorrowHistoryDto(_publicationRepo.GetPublicationById(publicationId));
        public PublicationDto CreatePublication(PublicationInputModel body) 
            => new PublicationDto(_publicationRepo.CreatePublication(body));
        public PublicationDto UpdatePublicationById(int publicationId, PublicationUpdateInputModel body) 
            => new PublicationDto(_publicationRepo.UpdatePublicationById(publicationId, body));
        public PublicationDto DeletePublicationById(int publicationId) 
            => new PublicationDto(_publicationRepo.DeletePublicationById(publicationId));
    }
}