using Microsoft.Extensions.DependencyInjection;
using Movies.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Business.Extensions
{
    public static class MappingRegistration 
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MappingProfile));

        }
    }
}
