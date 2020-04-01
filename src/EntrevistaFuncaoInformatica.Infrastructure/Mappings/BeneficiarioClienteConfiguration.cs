using EntrevistaFuncaoInformatica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrevistaFuncaoInformatica.Infrastructure.Mappings
{
	public class BeneficiarioClienteConfiguration : IEntityTypeConfiguration<BeneficiarioCliente>
	{
		public void Configure(EntityTypeBuilder<BeneficiarioCliente> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Codigo).HasMaxLength(255).IsRequired();
			builder.Property(c => c.CPF).HasMaxLength(15).IsRequired();
			builder.Property(c => c.Nome).HasMaxLength(255).IsRequired();
			builder.Property(c => c.DataRegistro).IsRequired();

			builder.HasOne(c => c.ClienteSistema).WithMany(c => c.BeneficiarioClientes).HasForeignKey(c => c.ClienteSistemaId).OnDelete(DeleteBehavior.Restrict).IsRequired();

			builder.HasIndex(c => c.Codigo).HasName("IX_BeneficiarioClientes_Codigo").IsUnique();
		}
	}
}
