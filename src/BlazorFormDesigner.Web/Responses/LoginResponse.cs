using BlazorFormDesigner.Web.Models;
using System;

namespace BlazorFormDesigner.Web.Responses
{
    public class LoginResponse
    {
        public string Username { get; set; }

        public string Name { get; set; }

        public string Token { get; set; }

        public string District { get; set; }

        internal User ToUser()
        {
            var user = new User();
            // TODO
            return user;
        }
    }
}