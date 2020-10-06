using AutoMapper;

namespace BlazorFormDesigner.Api.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Database - Models
            CreateMap<Database.Entities.User, BusinessLogic.Models.User>();
            CreateMap<BusinessLogic.Models.User, Database.Entities.User>();

            //Requests - Models
            CreateMap<Web.Requests.UserRequest, BusinessLogic.Models.User>();

            //Models - Responses
            CreateMap<BusinessLogic.Models.User, Web.Responses.UserResponse>();
            CreateMap<BusinessLogic.Models.User, Web.Responses.LoginResponse>();
        }
    }
}
