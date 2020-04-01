using EntrevistaFuncaoInformatica.Domain.Enums;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IResult
	{
		bool Sucesso { get; set; }
		string Mensagem { get; set; }
    }
}
