using System;

namespace AcademicReferenceManager.Models.Exceptions
{
    public class AuthorizationException : Exception
    {
        public AuthorizationException() : base("You are unauthorized!") {}
        public AuthorizationException(string message) : base(message) {}
        public AuthorizationException(string message, Exception inner) : base (message, inner) {}
    }
}