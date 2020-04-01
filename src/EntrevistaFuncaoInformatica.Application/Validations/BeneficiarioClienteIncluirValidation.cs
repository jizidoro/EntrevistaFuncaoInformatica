using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class BeneficiarioClienteIncluirValidation : BeneficiarioClienteValidation<BeneficiarioClienteIncluirDto>
	{
		public BeneficiarioClienteIncluirValidation()
		{
			ValidarCPF();
			ValidarNome();
		}
	}
}
