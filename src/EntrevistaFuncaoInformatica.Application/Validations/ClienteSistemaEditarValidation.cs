using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class ClienteSistemaEditarValidation : ClienteSistemaValidation<ClienteSistemaEditarDto>
	{
		public ClienteSistemaEditarValidation()
		{
			ValidarId();
			ValidarCPF();
			ValidarNome();
			ValidarSobrenome();
			ValidarNacionalidade();
			ValidarCep();
			ValidarEstado();
			ValidarCidade();
			ValidarLogradouro();
			ValidarEmail();
			ValidarTelefone();
		}
	}
}
