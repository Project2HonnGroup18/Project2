using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Interfaces;

namespace AcademicReferenceManager.Repositories.Implementations
{
    public class PublicationRepository : IPublicationRepository
    {
        private readonly ArmDbContext _armDbContext;

        public PublicationRepository(ArmDbContext armDbContext) 
        {
            _armDbContext = armDbContext;
        }

        public IEnumerable<Publication> GetAllPublications() => _armDbContext.Publications.Select(p => new Publication
        {
            Id = p.Id,
            EditorFirstName = p.EditorFirstName,
            EditorLastName = p.EditorLastName,
            Title = p.Title,
            Year = p.Year,
            Type = p.Type,
            Isbn = p.Isbn
        });

        public Publication GetPublicationById(int publicationId)
        {
            // Validate that given publication exists
             var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
             if(publication == null)
             {
                 throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
             }
             return new Publication
             {
                Id = publication.Id,
                EditorFirstName = publication.EditorFirstName,
                EditorLastName = publication.EditorLastName,
                Title = publication.Title,
                Year = publication.Year,
                Type = publication.Type,
                Isbn = publication.Isbn
             };
        }

        public Publication CreatePublication(PublicationInputModel body)
        {
            // Validate that given publication does not exists in database
            bool publicationsExists = _armDbContext.Publications.Any(p => p.Isbn == body.Isbn);
            if(publicationsExists)
            {
                throw new ModelFormatException("This publication already Exists");
            }

            // check if we have publications in db if not set Id to 1 else find the highest Id and add 1 to it
            int nextInt = 0;
            if(_armDbContext.Publications.Count() == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _armDbContext.Publications.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            }
            var entity = new Publication
            {
                Id = nextInt,
                EditorFirstName = body.EditorFirstName,
                EditorLastName = body.EditorLastName,
                Title = body.Title,
                Journal = body.Journal,
                Isbn = body.Isbn,
                Year = body.Year,
                Type = body.Type
            };
            _armDbContext.Publications.Add(entity);
            _armDbContext.SaveChanges();
            return entity;
        }
        public Publication UpdatePublicationById(int publicationId, PublicationUpdateInputModel body)
        {
            // Validate that given publication exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
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
            _armDbContext.SaveChanges();
            
            return publication;
        }
        
        public Publication DeletePublicationById(int publicationId) 
        {
            // Validate that given publication exists
            var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
            }
            _armDbContext.Remove(publication);
            _armDbContext.SaveChanges();

            return publication;
        }
    }
}