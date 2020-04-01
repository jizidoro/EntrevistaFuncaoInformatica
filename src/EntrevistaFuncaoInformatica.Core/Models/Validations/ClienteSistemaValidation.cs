using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Core.Models.Results;
using EntrevistaFuncaoInformatica.Core.Repositories;
using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Models.Validations
{
	public class ClienteSistemaValidation : EntityValidation<ClienteSistema>, IClienteSistemaValidation
	{
		private readonly IClienteSistemaRepository repository;

		public ClienteSistemaValidation(IClienteSistemaRepository repository)
			: base(repository)
		{
			this.repository = repository;
		}

		public async Task<ISingleResult<ClienteSistema>> ValidarSeExisteMesmoCodigo(ClienteSistema entity)
		{
			var result = await repository.RegistroComMesmoCodigo(entity.Id, entity.Codigo);
			if (!result.Sucesso)
			{
				return result;
			}

			return new SingleResult<ClienteSistema>();
		}

		public async Task<ISingleResult<ClienteSistema>> ValidarInclusao(ClienteSistema entity)
		{
			return await ValidarSeExisteMesmoCodigo(entity);
		}

		public async Task<ISingleResult<ClienteSistema>> ValidarEdicao(ClienteSistema entity)
		{
			var registroExiste = await RegistroExiste(entity.Id);
			if (!registroExiste.Sucesso)
			{
				return registroExiste;
			}

			var registroExisteMesmoCodigo = await ValidarSeExisteMesmoCodigo(entity);
			if (!registroExisteMesmoCodigo.Sucesso)
			{
				return registroExisteMesmoCodigo;
			}

			registroExisteMesmoCodigo.Data = registroExiste.Data;

			return registroExisteMesmoCodigo;
		}

		public async Task<ISingleResult<ClienteSistema>> ValidarExclusao(int id)
		{
			var registroExiste = await RegistroExiste(id);
			if (!registroExiste.Sucesso)
			{
				return registroExiste;
			}

			return new SingleResult<ClienteSistema>();
		}
	}
}
