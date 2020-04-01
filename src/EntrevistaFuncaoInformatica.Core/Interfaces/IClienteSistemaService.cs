using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IClienteSistemaService
	{
		Task<ISingleResult<ClienteSistema>> Incluir(ClienteSistema entity);

		Task<ISingleResult<ClienteSistema>> Editar(ClienteSistema entity);

		Task<ISingleResult<ClienteSistema>> Excluir(int id);
	}
}
