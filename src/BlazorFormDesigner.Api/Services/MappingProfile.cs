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

            CreateMap<Database.Entities.Form, BusinessLogic.Models.Form>();
            CreateMap<BusinessLogic.Models.Form, Database.Entities.Form>();

            CreateMap<Database.Entities.Question, BusinessLogic.Models.Question>();
            CreateMap<BusinessLogic.Models.Question, Database.Entities.Question>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Database.Entities.Option, BusinessLogic.Models.Option>();
            CreateMap<BusinessLogic.Models.Option, Database.Entities.Option>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //Requests - Models
            CreateMap<Web.Requests.UserRequest, BusinessLogic.Models.User>();
            CreateMap<Web.Requests.FormRequest, BusinessLogic.Models.Form>();
            CreateMap<Web.Requests.QuestionRequest, BusinessLogic.Models.Question>();
            CreateMap<Web.Requests.OptionRequest, BusinessLogic.Models.Option>();

            //Models - Responses
            CreateMap<BusinessLogic.Models.User, Web.Responses.UserResponse>();
            CreateMap<BusinessLogic.Models.User, Web.Responses.LoginResponse>();
        }
    }
}
