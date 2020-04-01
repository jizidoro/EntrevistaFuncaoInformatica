using EntrevistaFuncaoInformatica.Domain.Bases;
using System;

namespace EntrevistaFuncaoInformatica.Domain.Models
{
	public class BeneficiarioCliente : Entity
    {
		public int ClienteSistemaId { get; set; }
		public ClienteSistema ClienteSistema { get; set; }

		public string Codigo { get; set; }
		public string CPF { get; set; }
		public string Nome { get; set; }
		public DateTime DataRegistro { get; set; }

		public override string Value => this.Codigo;
	}
}
