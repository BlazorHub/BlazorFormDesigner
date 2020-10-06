using AutoMapper;
using BlazorFormDesigner.BusinessLogic.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorFormDesigner.Database.Converters
{
    public static class EntityToModelConverter
    {
        public static User ToModel(this Entities.User entity, IMapper mapper)
        {
            return mapper.Map<User>(entity);
        }

        public static List<User> ToModel(this IEnumerable<Entities.User> entities, IMapper mapper)
        {
            return entities.Select(entity => entity.ToModel(mapper)).ToList();
        }
    }
}