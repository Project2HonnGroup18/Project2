using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Services.Interfaces
{
    public interface INewFriendService
    {
        List<Friend> Get();
    }
}