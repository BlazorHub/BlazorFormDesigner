using AutoMapper;
using BlazorFormDesigner.BusinessLogic.Models;
using BlazorFormDesigner.Web.Requests;

namespace BlazorFormDesigner.Api.Converters
{
    public static class DTOToModelConverter
    {
        public static User ToModel(this UserRequest dto, IMapper mapper)
        {
            return mapper.Map<User>(dto);
        }
    }
}
