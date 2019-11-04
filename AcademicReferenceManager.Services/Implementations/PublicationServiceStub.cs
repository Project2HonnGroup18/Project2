using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Services.Interfaces;

namespace AcademicReferenceManager.Services.Implementations
{
    public class PublicationServiceStub : IPublicationService
    {
        private readonly List<Publication> _publications;

        public PublicationServiceStub()
        {
            _publications = new List<Publication>()
            {
                new Publication()
                {
                    Id = 1,
                    EditorFirstName = "David",
                    EditorLastName = "David",
                    Title = "Davids pub",
                    Journal = "World Scientific",
                    Isbn = "124601285-0",
                    Year = 2019,
                    Type = "electronic"
                },

                new Publication()
                {
                    Id = 2,
                    EditorFirstName = "John",
                    EditorLastName = "Smith",
                    Title = "Johns pub",
                    Journal = "World Scientific",
                    Isbn = "124612345-0",
                    Year = 2019,
                    Type = "printed"
                },

                new Publication()
                {
                    Id = 3,
                    EditorFirstName = "Frank",
                    EditorLastName = "Miller",
                    Title = "Frankies pub",
                    Journal = "World Scientific",
                    Isbn = "124612345-0",
                    Year = 2019,
                    Type = "electronic"
                }
            };
        }
        
        public PublicationDto CreatePublication(PublicationInputModel body)
        {
            
            var entity = new Publication
            {
                EditorFirstName = body.EditorFirstName,
                EditorLastName = body.EditorLastName,
                Title = body.Title,
                Journal = body.Journal,
                Isbn = body.Isbn,
                Year = body.Year,
                Type = body.Type
            };
            
            _publications.Add(entity);
            return new PublicationDto()
            {
                EditorFirstName = entity.EditorFirstName,
                EditorLastName = entity.EditorLastName,
                Title = entity.Title,
                Isbn = entity.Isbn,
                Year = entity.Year,
                Type = entity.Type
            };
        }

        public PublicationDto DeletePublicationById(int publicationId)
        {
            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }
            _publications.Remove(publication);

            return new PublicationDto()
            {
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Isbn = publication.Isbn,
                Year = publication.Year,
                Type = publication.Type
            };
        }

        public IEnumerable<PublicationDto> GetAllPublications(DateTime? loanDate)
        {
            var publications = _publications.Select(p => new PublicationDto
            {
                EditorFirstName = p.EditorFirstName,
                EditorLastName = p.EditorLastName,
                Title = p.Title,
                Isbn = p.Isbn,
                Year = p.Year,
                Type = p.Type
            });
            
            return publications;
        }

        public PublicationWithBorrowHistoryDto GetPublicationById(int publicationId)
        {
            var publication = _publications.Where(p => p.Id == publicationId).FirstOrDefault();
            if(publication == null) 
            {
                throw new ResourceNotFoundException($"User with id: {publicationId} was not found");     
            }
            return new PublicationWithBorrowHistoryDto
            {
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Isbn = publication.Isbn,
                Year = publication.Year,
                Type = publication.Type
            };
        }

        public PublicationDto UpdatePublicationById(int publicationId, PublicationUpdateInputModel body)
        {
            // Validate that given publication exists
            var publication = _publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }

            // Check if given publication has values if it has values change the old value to the new value
            // if it doesn't we keep the old value so that all other values do not become null
            publication.EditorFirstName = string.IsNullOrEmpty(body.EditorFirstName) ? publication.EditorFirstName : body.EditorFirstName;
            publication.EditorLastName = string.IsNullOrEmpty(body.EditorLastName) ? publication.EditorLastName : body.EditorLastName;
            publication.Title = string.IsNullOrEmpty(body.Title) ? publication.Title : body.Title;
            publication.Journal = string.IsNullOrEmpty(body.Journal) ? publication.Journal : body.Journal;
            publication.Isbn = string.IsNullOrEmpty(body.Isbn) ? publication.Isbn : body.Isbn;
            publication.Year = body.Year.HasValue ? publication.Year : body.Year;
            publication.Type = string.IsNullOrEmpty(body.Type) ?  publication.Type : body.Type;
            
            return new PublicationDto()
            {
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Isbn = publication.Isbn,
                Year = publication.Year,
                Type = publication.Type

            };
        }
    }
}