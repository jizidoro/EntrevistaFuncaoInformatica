using EntrevistaFuncaoInformatica.Application.Bases;
using System;

namespace EntrevistaFuncaoInformatica.Application.Dtos
{
	public class BeneficiarioClienteDto : EntityDto
	{
		public int ClienteSistemaId { get; set; }
		public string Codigo { get; set; }
		public string CPF { get; set; }
		public string Nome { get; set; }
		public DateTime DataRegistro { get; set; }
	}

	public class BeneficiarioClienteEditarDto : BeneficiarioClienteIncluirDto
	{
	}

	public class BeneficiarioClienteExcluirDto : EntityDto
	{
	}

	public class BeneficiarioClienteIncluirDto : BeneficiarioClienteDto
	{
	}
}
