using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IClienteSistemaValidation
	{
		Task<ISingleResult<ClienteSistema>> ValidarInclusao(ClienteSistema entity);

		Task<ISingleResult<ClienteSistema>> ValidarEdicao(ClienteSistema entity);

		Task<ISingleResult<ClienteSistema>> ValidarExclusao(int id);
	}
}
