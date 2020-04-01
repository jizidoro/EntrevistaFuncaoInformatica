using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Repositories
{
	public interface IClienteSistemaRepository : IRepository<ClienteSistema>
    {
		Task<ISingleResult<ClienteSistema>> RegistroComMesmoCodigo(int id, string codigo);
	}
}
