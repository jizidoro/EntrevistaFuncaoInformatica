using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Core.Models.Results;
using EntrevistaFuncaoInformatica.Core.Repositories;
using EntrevistaFuncaoInformatica.Domain.Models;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Models.Validations
{
	public class BeneficiarioClienteValidation : EntityValidation<BeneficiarioCliente>, IBeneficiarioClienteValidation
	{
		private readonly IBeneficiarioClienteRepository repository;

		public BeneficiarioClienteValidation(IBeneficiarioClienteRepository repository)
			: base(repository)
		{
			this.repository = repository;
		}

		public async Task<ISingleResult<BeneficiarioCliente>> ValidarSeExisteMesmoCodigo(BeneficiarioCliente entity)
		{
			var result = await repository.RegistroComMesmoCodigo(entity.Id, entity.Codigo);
			if (!result.Sucesso)
			{
				return result;
			}

			return new SingleResult<BeneficiarioCliente>();
		}

		public async Task<ISingleResult<BeneficiarioCliente>> ValidarInclusao(BeneficiarioCliente entity)
		{
			return await ValidarSeExisteMesmoCodigo(entity);
		}

		public async Task<ISingleResult<BeneficiarioCliente>> ValidarEdicao(BeneficiarioCliente entity)
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

		public async Task<ISingleResult<BeneficiarioCliente>> ValidarExclusao(int id)
		{
			var registroExiste = await RegistroExiste(id);
			if (!registroExiste.Sucesso)
			{
				return registroExiste;
			}

			return new SingleResult<BeneficiarioCliente>();
		}
	}
}
