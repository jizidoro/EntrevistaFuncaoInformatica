using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IBeneficiarioClienteService
	{
		Task<ISingleResult<BeneficiarioCliente>> Incluir(BeneficiarioCliente entity);

		Task<ISingleResult<BeneficiarioCliente>> Editar(BeneficiarioCliente entity);

		Task<ISingleResult<BeneficiarioCliente>> Excluir(int id);
	}
}
