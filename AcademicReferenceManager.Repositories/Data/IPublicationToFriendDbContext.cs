using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data
{
    public interface IPublicationToFriendDbContext
    {
         List<PublicationToFriend> PublicationsToFriend { get; }
    }
}