using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Application.Interfaces
{
	public interface IClienteSistemaAppService : IAppService
    {
		Task<IListResultDto<ClienteSistemaDto>> Listar();
		Task<ISingleResultDto<ClienteSistemaDto>> Obter(int id);
		Task<ISingleResultDto<EntityDto>> Incluir(ClienteSistemaIncluirDto dto);
		Task<ISingleResultDto<EntityDto>> Editar(ClienteSistemaEditarDto dto);
		Task<ISingleResultDto<EntityDto>> Excluir(int id);
	}
}
