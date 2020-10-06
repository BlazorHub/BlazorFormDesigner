using AutoMapper;
using BlazorFormDesigner.BusinessLogic.Models;
using LoginApp.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFormDesigner.Api.Controllers
{
    public class AppController : ControllerBase
    {
        protected readonly IMapper mapper;

        protected AppController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        protected new User User
        {
            get
            {
                string token = Request.Headers["Authorization"];
                return TokenService.DecodeToken(token?.Substring(7));
            }
        }
    }
}
