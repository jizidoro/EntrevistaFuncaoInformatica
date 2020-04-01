using EntrevistaFuncaoInformatica.Domain.Models;
using EntrevistaFuncaoInformatica.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EntrevistaFuncaoInformatica.Infrastructure.Data
{
	public class EntrevistaFuncaoInformaticaContext : DbContext
	{
		public EntrevistaFuncaoInformaticaContext(DbContextOptions<EntrevistaFuncaoInformaticaContext> options)
			: base(options)
		{			
		}

		// Tabelas
		public DbSet<BeneficiarioCliente> BeneficiarioClientes { get; set; }
		public DbSet<ClienteSistema> ClienteSistemas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Tabelas
			modelBuilder.ApplyConfiguration(new BeneficiarioClienteConfiguration());
			modelBuilder.ApplyConfiguration(new ClienteSistemaConfiguration());
		}
	}
}
