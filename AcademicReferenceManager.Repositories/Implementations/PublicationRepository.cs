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
        private readonly IPublicationDbContext _publicationDbContext;

        public PublicationRepository(IPublicationDbContext pDbContext) 
        {
            _publicationDbContext = pDbContext;
        }

        public IEnumerable<PublicationDto> GetAllPublications() => _publicationDbContext.Publications.Select(p => new PublicationDto
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
             var publication = _publicationDbContext.Publications.FirstOrDefault(p => p.Id == publicationId);
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
            bool publicationsExists = _publicationDbContext.Publications.Any(p => p.Isbn == body.Isbn);
            if(publicationsExists)
            {
                throw new ModelFormatException("This publication already Exists");
            }
            int nextInt = 0;
            if(_publicationDbContext.Publications.Count == 0)
            {
                nextInt = 1;
            }
            else 
            {
                nextInt = _publicationDbContext.Publications.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
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
            _publicationDbContext.Publications.Add(entity);
            return entity;
        }
    }
}