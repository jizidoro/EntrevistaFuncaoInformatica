using EntrevistaFuncaoInformatica.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntrevistaFuncaoInformatica.Infrastructure.Mappings
{
	public class ClienteSistemaConfiguration : IEntityTypeConfiguration<ClienteSistema>
	{
		public void Configure(EntityTypeBuilder<ClienteSistema> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Codigo).HasMaxLength(255).IsRequired();
			builder.Property(c => c.CPF).HasMaxLength(15).IsRequired();
			builder.Property(c => c.Nome).HasMaxLength(127).IsRequired();
			builder.Property(c => c.Sobrenome).HasMaxLength(127).IsRequired();
			builder.Property(c => c.Nacionalidade).HasMaxLength(63).IsRequired();
			builder.Property(c => c.Cep).HasMaxLength(15).IsRequired();
			builder.Property(c => c.Estado).HasMaxLength(63).IsRequired();
			builder.Property(c => c.Cidade).HasMaxLength(63).IsRequired();
			builder.Property(c => c.Logradouro).HasMaxLength(31).IsRequired();
			builder.Property(c => c.Email).HasMaxLength(255).IsRequired();
			builder.Property(c => c.Telefone).HasMaxLength(31).IsRequired();
			builder.Property(c => c.DataRegistro).IsRequired();

			builder.HasMany(c => c.BeneficiarioClientes).WithOne(c => c.ClienteSistema).HasForeignKey(c => c.ClienteSistemaId);

			builder.HasIndex(c => c.Codigo).HasName("IX_ClienteSistemas_Codigo").IsUnique();
		}
	}
}
