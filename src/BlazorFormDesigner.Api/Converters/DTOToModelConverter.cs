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

        public static Form ToModel(this FormRequest dto, IMapper mapper)
        {
            return mapper.Map<Form>(dto);
        }

        public static Question ToModel(this QuestionRequest dto, IMapper mapper)
        {
            return mapper.Map<Question>(dto);
        }

        public static Option ToModel(this OptionRequest dto, IMapper mapper)
        {
            return mapper.Map<Option>(dto);
        }
    }
}
