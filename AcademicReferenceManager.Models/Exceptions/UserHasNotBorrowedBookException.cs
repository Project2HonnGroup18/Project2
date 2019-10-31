using System;

namespace AcademicReferenceManager.Models.Exceptions
{
    public class UserHasNotBorrowedBookException : Exception
    {
        public UserHasNotBorrowedBookException() : base("Conflict, user has not borrowed this book") {}
        public UserHasNotBorrowedBookException(string message) : base(message) {}
        public UserHasNotBorrowedBookException(string message, Exception inner) : base (message, inner) {}
    }
}