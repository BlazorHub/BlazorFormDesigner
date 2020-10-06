using System.Threading.Tasks;
using AutoMapper;
using BlazorFormDesigner.Api.Converters;
using BlazorFormDesigner.BusinessLogic.Services;
using BlazorFormDesigner.Web.Requests;
using BlazorFormDesigner.Web.Responses;
using LoginApp.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFormDesigner.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : AppController
    {
        private readonly UserService UserService;

        public UserController(UserService userService, IMapper mapper) : base(mapper)
        {
            UserService = userService;
        }

        [HttpPut]
        public async Task<ActionResult<LoginResponse>> Login(LoginRequest request)
        {
            var user = await UserService.ValidatePassword(request.Username, request.Password);

            var token = TokenService.GenerateToken(user.Username);

            return Ok(user.ToDTO(mapper, token));
        }
    }
}
