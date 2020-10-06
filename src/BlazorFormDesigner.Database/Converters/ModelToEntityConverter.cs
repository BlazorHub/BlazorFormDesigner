using AutoMapper;
using BlazorFormDesigner.BusinessLogic.Models;

namespace BlazorFormDesigner.Database.Converters
{
    public static class ModelToEntityConverter
    {
        public static Entities.User WithPassword(this Entities.User entity, string password, byte[] salt)
        {
            entity.Password = password;
            entity.Salt = salt;
            return entity;
        }

        public static Entities.User ToEntity(this User model, IMapper mapper)
        {
            return mapper.Map<Entities.User>(model);
        }
    }
}
