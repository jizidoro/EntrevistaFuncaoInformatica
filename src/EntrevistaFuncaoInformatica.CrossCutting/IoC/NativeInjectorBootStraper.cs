using EntrevistaFuncaoInformatica.Application.Interfaces;
using EntrevistaFuncaoInformatica.Application.Services;
using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Core.Models.Validations;
using EntrevistaFuncaoInformatica.Core.Repositories;
using EntrevistaFuncaoInformatica.Core.Services;
using EntrevistaFuncaoInformatica.CrossCutting.Models;
using EntrevistaFuncaoInformatica.Infrastructure.Bases;
using EntrevistaFuncaoInformatica.Infrastructure.Data;
using EntrevistaFuncaoInformatica.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntrevistaFuncaoInformatica.CrossCutting.IoC
{
    public static class NativeInjectorBootStraper
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration config, bool isTest)
        {
            // AspNetUser
            services.AddScoped<IUser, AspNetUser>();
            
            // Application - Services
            services.AddScoped<IBeneficiarioClienteAppService, BeneficiarioClienteAppService>();
            services.AddScoped<IClienteSistemaAppService, ClienteSistemaAppService>();

            // Core - Services
            services.AddScoped<IBeneficiarioClienteService, BeneficiarioClienteService>();
            services.AddScoped<IClienteSistemaService, ClienteSistemaService>();

            // Core - Validations
            services.AddScoped<IBeneficiarioClienteValidation, BeneficiarioClienteValidation>();
            services.AddScoped<IClienteSistemaValidation, ClienteSistemaValidation>();

            // Infra - Data
            services.AddScoped<IBeneficiarioClienteRepository, BeneficiarioClienteRepository>();
            services.AddScoped<IClienteSistemaRepository, ClienteSistemaRepository>();


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        public static void UpdateDatabase(IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetService<EntrevistaFuncaoInformaticaContext>();
            context.Database.Migrate();
        }
    }
}
