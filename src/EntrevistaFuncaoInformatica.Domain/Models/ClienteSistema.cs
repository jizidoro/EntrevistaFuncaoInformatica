using EntrevistaFuncaoInformatica.Domain.Bases;
using System;
using System.Collections.Generic;

namespace EntrevistaFuncaoInformatica.Domain.Models
{
	public class ClienteSistema : Entity
    {
		public IEnumerable<BeneficiarioCliente> BeneficiarioClientes { get; set;}

		public string Codigo { get; set; }
		public string CPF { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public string Nacionalidade { get; set; }
		public string Cep { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string Logradouro { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public DateTime DataRegistro { get; set; }

		public override string Value => this.Codigo;
	}
}
