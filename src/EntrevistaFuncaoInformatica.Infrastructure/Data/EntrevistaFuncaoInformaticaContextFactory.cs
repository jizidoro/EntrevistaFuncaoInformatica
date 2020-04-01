using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EntrevistaFuncaoInformatica.Infrastructure.Data
{
	public class EntrevistaFuncaoInformaticaContextFactory : IDesignTimeDbContextFactory<EntrevistaFuncaoInformaticaContext>
	{
		public EntrevistaFuncaoInformaticaContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<EntrevistaFuncaoInformaticaContext>();

			// get the configuration from the app settings
			var config = new ConfigurationBuilder()
			   .SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsettings.json")
			   .Build();

			// define the database to use
			optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

			return new EntrevistaFuncaoInformaticaContext(optionsBuilder.Options);
		}
	}
}
