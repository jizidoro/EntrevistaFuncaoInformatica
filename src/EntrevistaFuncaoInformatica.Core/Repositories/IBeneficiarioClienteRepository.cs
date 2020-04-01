using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Repositories
{
	public interface IBeneficiarioClienteRepository : IRepository<BeneficiarioCliente>
    {
		Task<ISingleResult<BeneficiarioCliente>> RegistroComMesmoCodigo(int id, string codigo);
	}
}
