using EntrevistaFuncaoInformatica.Application.Dtos;

namespace EntrevistaFuncaoInformatica.Application.Validations
{
	public class ClienteSistemaIncluirValidation : ClienteSistemaValidation<ClienteSistemaIncluirDto>
	{
		public ClienteSistemaIncluirValidation()
		{
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
