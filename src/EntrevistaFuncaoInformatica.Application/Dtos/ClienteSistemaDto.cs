using EntrevistaFuncaoInformatica.Application.Bases;
using System;
using System.Collections.Generic;

namespace EntrevistaFuncaoInformatica.Application.Dtos
{
	public class ClienteSistemaDto : EntityDto
	{
		public ClienteSistemaDto() 
		{
			BeneficiarioClientes = new List<BeneficiarioClienteDto>();
		}

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

		public List<BeneficiarioClienteDto> BeneficiarioClientes { get; set; }
	}

	public class ClienteSistemaEditarDto : ClienteSistemaIncluirDto
	{
	}

	public class ClienteSistemaExcluirDto : EntityDto
	{
	}

	public class ClienteSistemaIncluirDto : ClienteSistemaDto
	{
	}
}
