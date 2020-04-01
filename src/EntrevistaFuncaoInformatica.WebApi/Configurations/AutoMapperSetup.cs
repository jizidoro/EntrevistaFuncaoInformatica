using System;
using AutoMapper;
using EntrevistaFuncaoInformatica.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace EntrevistaFuncaoInformatica.WebApi.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToDtoMappingProfile), typeof(DtoToDomainMappingProfile));
        }
    }
}