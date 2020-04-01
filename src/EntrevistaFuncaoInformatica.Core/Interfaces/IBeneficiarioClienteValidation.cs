using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IBeneficiarioClienteValidation
	{
		Task<ISingleResult<BeneficiarioCliente>> ValidarInclusao(BeneficiarioCliente entity);

		Task<ISingleResult<BeneficiarioCliente>> ValidarEdicao(BeneficiarioCliente entity);

		Task<ISingleResult<BeneficiarioCliente>> ValidarExclusao(int id);
	}
}
