using System;
using System.Collections.Generic;
using AcademicReferenceManager.Models.Entities;

namespace AcademicReferenceManager.Repositories.Data
{
    public class PublicationToFriendDbContext : IPublicationToFriendDbContext
    {
        private readonly List<PublicationToFriend> _publicationsToFriend = new List<PublicationToFriend> 
        {
            new PublicationToFriend
            {
                Id = 1,
                //FriendId = 1,
                BorrowDate = new DateTime(),
                ReturnDate = DateTime.Now,
                //PublicationId = 1
            },

            new PublicationToFriend
            {
                Id = 2,
                //FriendId = 2,
                BorrowDate = DateTime.Parse("2019-09-09"),
                ReturnDate = DateTime.Parse("2019-10-09"),
                //PublicationId = 1
            },

            new PublicationToFriend
            {
                Id = 3,
                //FriendId = 3,
                BorrowDate = DateTime.Parse("2019-09-09"),
                ReturnDate = DateTime.Parse("2019-10-10"),
                //PublicationId = 3
            },

            new PublicationToFriend
            {
                Id = 4,
                //FriendId = 5,
                BorrowDate = DateTime.Parse("2019-09-09"),
                ReturnDate = DateTime.Parse("2019-09-10"),
                //PublicationId = 10
            },
        };

        public List<PublicationToFriend> PublicationsToFriend => _publicationsToFriend;
    }
}