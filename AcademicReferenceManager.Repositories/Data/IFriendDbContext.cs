using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data
{
    public interface IFriendDbContext
    {
        List<Friend> Friends { get; }
    }
}