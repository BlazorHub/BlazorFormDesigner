using System.Collections.Generic;
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
    public class FormController : AppController
    {
        private readonly FormService FormService;

        public FormController(FormService formService, IMapper mapper) : base(mapper)
        {
            FormService = formService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LoginResponse>>> GetAll()
        {
            var forms = await FormService.GetAll();

            return Ok(forms);
        }
    }
}
