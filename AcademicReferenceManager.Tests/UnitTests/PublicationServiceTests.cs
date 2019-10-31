using System;
using Xunit;
using AcademicReferenceManager.Services.Implementations;
using AcademicReferenceManager.Repositories.Data;
using AcademicReferenceManager.Repositories.Implementations;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.InputModels;
using AcademicReferenceManager.Models.Entities;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace UnitTests
{
    //TODO: full CRUD testing
    public class PublicationServiceTests
    {
        public readonly PublicationService _publicationService;
        public readonly List<PublicationInputModel> _inputModels;
        public PublicationServiceTests()
        {
            var dbOptionsBuilder = new DbContextOptionsBuilder<ArmDbContext>().UseInMemoryDatabase("InMemoryDatabase");
            ArmDbContext db = new ArmDbContext(options: dbOptionsBuilder.Options);
 
            PublicationRepository publicationRepository = new PublicationRepository(db);
            BorrowRepository borrowRepository = new BorrowRepository(db);
            _publicationService = new PublicationService(publicationRepository, borrowRepository);

            _inputModels =  new List<PublicationInputModel>();
            _inputModels.Add(new PublicationInputModel{
                Title = "Not a real publication",
                Isbn = "5812345"
            });
            _inputModels.Add(new PublicationInputModel{
                Title = "asd",
                Isbn = "strengur"
            });
            _inputModels.Add(new PublicationInputModel{
                Title = "asdf",
                Isbn = "string"
            });
            
        }

        [Fact]
        public void TestGettingAllPublications()
        {
            DateTime loanDate = new DateTime(2019, 1, 1);
            var publications = _publicationService.GetAllPublications(loanDate);
            Assert.NotNull(publications);
        }

        [Fact]
        public void TestAddingPublicationByComparison()
        {

            Publication createdPublication = _publicationService.CreatePublication(_inputModels[0]);
            bool samePublication = createdPublication.Title == _inputModels[0].Title;
            samePublication = samePublication && createdPublication.Isbn == _inputModels[0].Isbn;
            Assert.True(samePublication);
        }

        [Fact]
        public void TestAddingPublicationByCounting()
        {
            //DateTime loanDate = new DateTime(2019, 1, 1);
            // Get original people list size, add publication then re-fetch the size.
            // Underlying implementation is unknown, so we cannot rely on the original list changing in size.
            int originalCount = _publicationService.GetAllPublications(null).ToList().Count;
            Publication createdPublication = _publicationService.CreatePublication(_inputModels[1]);
            int newCount = _publicationService.GetAllPublications(null).ToList().Count;

            Assert.Equal(originalCount + 1, newCount);
        }

        [Fact]
        public void TestAddingPublicationAndUsingId()
        {

            Publication createdPublication = _publicationService.CreatePublication(_inputModels[2]);
            PublicationDto rePublication = _publicationService.GetPublicationById(createdPublication.Id);

            bool samePublication = createdPublication.Id == rePublication.Id;
            samePublication = samePublication && createdPublication.Title == _inputModels[2].Title;
            samePublication = samePublication && createdPublication.Isbn == _inputModels[2].Isbn;
            Assert.True(samePublication);
        }
    }
}