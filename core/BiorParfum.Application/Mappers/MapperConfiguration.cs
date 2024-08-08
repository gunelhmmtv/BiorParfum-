using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Mappers
{
    public class MapperConfiguration : Profile
    {

        public MapperConfiguration()
        {
            var mappers = GetStandartMaps();

            foreach (var item in mappers)
            {
                CreateMap(item.Source, item.Destination).ReverseMap();
            }
        }
        private static IEnumerable<MapModel> GetStandartMaps()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            return types
                .SelectMany(type => type.GetInterfaces()
                    .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapTo<>))
                    .Select(i => new MapModel
                    {
                        Source = type,
                        Destination = i.GenericTypeArguments[0]
                    }))
                .ToList();
        }
    }
}
