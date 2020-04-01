using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class BeneficiarioClienteEditarValidation : BeneficiarioClienteValidation<BeneficiarioClienteEditarDto>
	{
		public BeneficiarioClienteEditarValidation()
		{
			ValidarId();
			ValidarCPF();
			ValidarNome();
		}
	}
}
