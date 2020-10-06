using System;

namespace BlazorFormDesigner.Database.Exceptions
{
    public class DuplicateUsernameException : Exception
    {
        public string Username { get; }

        public DuplicateUsernameException(string username)
        {
            Username = username;
        }
    }
}
