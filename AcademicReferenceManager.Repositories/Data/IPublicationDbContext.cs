using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data
{
    public interface IPublicationDbContext
    {
        List<Publication> Publications { get; }
    }
}