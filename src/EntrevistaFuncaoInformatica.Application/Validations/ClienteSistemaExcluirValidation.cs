using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class ClienteSistemaExcluirValidation : DtoValidation<ClienteSistemaExcluirDto>
	{
		public ClienteSistemaExcluirValidation()
		{
			ValidarId();
		}
	}
}
