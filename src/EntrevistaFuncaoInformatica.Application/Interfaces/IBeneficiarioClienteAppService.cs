using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Application.Interfaces
{
	public interface IBeneficiarioClienteAppService : IAppService
    {
		Task<IListResultDto<BeneficiarioClienteDto>> Listar();
		Task<ISingleResultDto<BeneficiarioClienteDto>> Obter(int id);
		Task<ISingleResultDto<EntityDto>> Incluir(BeneficiarioClienteIncluirDto dto);
		Task<ISingleResultDto<EntityDto>> Editar(BeneficiarioClienteEditarDto dto);
		Task<ISingleResultDto<EntityDto>> Excluir(int id);
	}
}
