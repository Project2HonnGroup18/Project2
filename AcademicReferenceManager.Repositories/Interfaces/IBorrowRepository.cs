using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Dtos;
using AcademicReferenceManager.Models.Entities;
using AcademicReferenceManager.Models.InputModels;

namespace AcademicReferenceManager.Repositories.Interfaces
{
    public interface IBorrowRepository
    {
        IEnumerable<PublicationToFriendDto> GetAllFriendBorrowsABookConnections();
        PublicationToFriendDto GetBorrowConnectionById(int connectionID);
        PublicationToFriend CreateFriendBorrowsABookConnection(PublicationToFriendInputModel body);
        //IEnumerable<FriendThatBorrowedPublicationDto> GetAllFriendsThatBorrowedPublicationsByParticularDate(DateTime date);
        //IEnumerable<FriendDto> GetAllFriendsThatBorrowedForLongerThanMonthByParticularDate(DateTime date);
        //IEnumerable<PublicationBorrowedByFriendDto> GetAllPublicationsThatAreOnLoanByParticularDate(DateTime date);
    }
}