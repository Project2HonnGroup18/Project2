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
namespace UnitTests
{
    //TODO: full CRUD testing
    public class PublicationServiceTests
    {
        public readonly PublicationService _publicationService;
        public readonly PublicationInputModel _inputModel;
        public PublicationServiceTests()
        {
            //Initialize the publication service, injecting a mock database.
            PublicationDbContext publicationDbContext = new PublicationDbContext();
            PublicationRepository publicationRepository = new PublicationRepository(publicationDbContext);
            _publicationService = new PublicationService(publicationRepository);

            _inputModel =  new PublicationInputModel();
            _inputModel.Title = "Not a real publication";
            _inputModel.Isbn = "5812345";
        }

        [Fact]
        public void TestGettingAllPublications()
        {
            var publications = _publicationService.GetAllPublications();
            Assert.NotNull(publications);
        }

        [Fact]
        public void TestAddingPublicationByComparison()
        {

            Publication createdPublication = _publicationService.CreatePublication(_inputModel);
            bool samePublication = createdPublication.Title == _inputModel.Title;
            samePublication = samePublication && createdPublication.Isbn == _inputModel.Isbn;
            Assert.True(samePublication);
        }

        [Fact]
        public void TestAddingPublicationByCounting()
        {
            // Get original people list size, add publication then re-fetch the size.
            // Underlying implementation is unknown, so we cannot rely on the original list changing in size.
            int originalCount = _publicationService.GetAllPublications().ToList().Count;
            Publication createdPublication = _publicationService.CreatePublication(_inputModel);
            int newCount = _publicationService.GetAllPublications().ToList().Count;

            Assert.Equal(originalCount + 1, newCount);
        }

        [Fact]
        public void TestAddingPublicationAndUsingId()
        {

            Publication createdPublication = _publicationService.CreatePublication(_inputModel);
            PublicationDto rePublication = _publicationService.GetPublicationById(createdPublication.Id);

            bool samePublication = createdPublication.Id == rePublication.Id;
            samePublication = samePublication && createdPublication.Title == _inputModel.Title;
            samePublication = samePublication && createdPublication.Isbn == _inputModel.Isbn;
            Assert.True(samePublication);
        }
    }
}