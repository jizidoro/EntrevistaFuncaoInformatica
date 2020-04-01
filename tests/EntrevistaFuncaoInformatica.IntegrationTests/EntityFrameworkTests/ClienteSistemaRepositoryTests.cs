namespace EntrevistaFuncaoInformatica.IntegrationTests.EntityFrameworkTests
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using EntrevistaFuncaoInformatica.Application.AutoMapper;
    using EntrevistaFuncaoInformatica.Application.Dtos;
    using EntrevistaFuncaoInformatica.Application.Services;
    using EntrevistaFuncaoInformatica.Core.Models.Validations;
    using EntrevistaFuncaoInformatica.Core.Services;
    using EntrevistaFuncaoInformatica.Domain.Models;
    using EntrevistaFuncaoInformatica.Infrastructure.Data;
    using EntrevistaFuncaoInformatica.Infrastructure.Repositories;
    using EntrevistaFuncaoInformatica.IntegrationTests.Helpers;
    using EntrevistaFuncaoInformatica.IntegrationTests.Helpers;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public sealed class ClienteSistemaRepositoryTests
    {
        private ClienteSistemaAppService ObterClienteSistemaAppService(EntrevistaFuncaoInformaticaContext context)
        {
            var uow = new UnitOfWork(context);
            var ClienteSistemaRepository = new ClienteSistemaRepository(context);
            var ClienteSistemaValidator = new ClienteSistemaValidation(ClienteSistemaRepository);
            var ClienteSistemaService = new ClienteSistemaService(ClienteSistemaRepository, ClienteSistemaValidator, uow);
            var mapper = MapperHelper.ConfigMapper();

            return new ClienteSistemaAppService(ClienteSistemaRepository, ClienteSistemaService, mapper);
        }


        [Fact]
        public async Task Add_ChangesDatabase()
        {
            var options = new DbContextOptionsBuilder<EntrevistaFuncaoInformaticaContext>()
                .UseInMemoryDatabase(databaseName: "test_database_change_database")
                .Options;


            var teste = new ClienteSistemaIncluirDto();
            teste.Codigo = "123";

            using (var context = new EntrevistaFuncaoInformaticaContext(options))
            {
                context.Database.EnsureCreated();

                var ClienteSistemaAppService = ObterClienteSistemaAppService(context);

                _ = await ClienteSistemaAppService.Incluir(teste);

                Assert.Equal(1, context.ClienteSistemas.Count());
            }
        }

        [Fact]
        public async Task Get_ReturnsClienteSistema()
        {
            var options = new DbContextOptionsBuilder<EntrevistaFuncaoInformaticaContext>()
                .UseInMemoryDatabase(databaseName: "test_database_return_ClienteSistema")
                .Options;

            ClienteSistema ClienteSistema = null;

            using (var context = new EntrevistaFuncaoInformaticaContext(options))
            {
                context.Database.EnsureCreated();
                Utilities.InitializeDbForTests(context);
                var repository = new ClienteSistemaRepository(context);
                ClienteSistema = await repository.GetById(1);
                Assert.NotNull(ClienteSistema);
            }
        }
    }
}
