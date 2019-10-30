using System;
using System.Collections.Generic;
using System.Linq;
using AcademicReferenceManager.Models.Dtos;
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

        public IEnumerable<PublicationDto> GetAllPublications() => _armDbContext.Publications.Select(p => new PublicationDto
        {
            Id = p.Id,
            EditorFirstName = p.EditorFirstName,
            EditorLastName = p.EditorLastName,
            Title = p.Title,
            Year = p.Year,
            Type = p.Type,
            Isbn = p.Isbn
        });

        public PublicationDto GetPublicationById(int publicationId)
        {
             var publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
             if(publication == null)
             {
                 throw new ResourceNotFoundException($"Publication with id: {publicationId} was not found");
             }
             return new PublicationDto
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
            bool publicationsExists = _armDbContext.Publications.Any(p => p.Isbn == body.Isbn);
            if(publicationsExists)
            {
                throw new ModelFormatException("This publication already Exists");
            }
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
            Publication publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException("Publication with id:" + publicationId + " was not found!");
            }
            var updatedPublication = new Publication{
                EditorFirstName = body.EditorFirstName,
                EditorLastName = string.IsNullOrEmpty(body.EditorLastName) ? publication.EditorFirstName : body.EditorFirstName,
                Title = string.IsNullOrEmpty(body.Title) ? publication.Title : body.Title,
                Journal = string.IsNullOrEmpty(body.Journal) ? publication.Journal : body.Journal,
                Isbn = string.IsNullOrEmpty(body.Isbn) ? publication.Isbn : body.Isbn,
                Year = body.Year.HasValue ? publication.Year : body.Year,
                Type = string.IsNullOrEmpty(body.Type) ?  publication.Type : body.Type
            };
            _armDbContext.Publications.Update(updatedPublication);
            _armDbContext.SaveChanges();
            
            return updatedPublication;
        }
        
        public Publication DeletePublicationById(int publicationId) 
        {
            Publication publication = _armDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
            if(publication == null)
            {
                throw new ResourceNotFoundException("Publication with id:" + publicationId + " was not found!");
            }
            _armDbContext.Remove(publication);
            _armDbContext.SaveChanges();

            return publication;
        }
    }
}