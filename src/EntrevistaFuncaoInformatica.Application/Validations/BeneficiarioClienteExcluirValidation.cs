using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class BeneficiarioClienteExcluirValidation : DtoValidation<BeneficiarioClienteExcluirDto>
	{
		public BeneficiarioClienteExcluirValidation()
		{
			ValidarId();
		}
	}
}
