using EntrevistaFuncaoInformatica.Core.Bases;
using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Core.Messages;
using EntrevistaFuncaoInformatica.Domain.Models;
using EntrevistaFuncaoInformatica.Core.Models.Results;
using EntrevistaFuncaoInformatica.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Services
{
	public class BeneficiarioClienteService : Service, IBeneficiarioClienteService
	{
		private readonly IBeneficiarioClienteRepository repository;		
		private readonly IBeneficiarioClienteValidation validator;

		public BeneficiarioClienteService(IBeneficiarioClienteRepository repository, IBeneficiarioClienteValidation validator, IUnitOfWork uow)
			: base(uow)
		{
			this.repository = repository;
			this.validator = validator;
		}

		public async Task<ISingleResult<BeneficiarioCliente>> Incluir(BeneficiarioCliente entity)
		{
			try
			{
				var validacao = await validator.ValidarInclusao(entity);
				if (!validacao.Sucesso)
				{
					return validacao;
				}
				entity.DataRegistro = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
				await repository.Add(entity);

				_ = await Commit();
			}
			catch (Exception)
			{
				return new SingleResult<BeneficiarioCliente>(MensagensNegocio.MSG07);
			}

			return new InclusaoResult<BeneficiarioCliente>(entity);
		}

		public async Task<ISingleResult<BeneficiarioCliente>> Editar(BeneficiarioCliente entity)
		{
			try
			{
				var result = await validator.ValidarEdicao(entity);
				if (!result.Sucesso)
				{
					return result;
				}

				var obj = result.Data;

				HydrateValues(obj, entity);

				repository.Update(obj);

				_ = await Commit();
			}
			catch (Exception ex)
			{
				return new SingleResult<BeneficiarioCliente>(ex);
			}

			return new EdicaoResult<BeneficiarioCliente>();
		}

		public async Task<ISingleResult<BeneficiarioCliente>> Excluir(int id)
		{
			try
			{
				var validacao = await validator.ValidarExclusao(id);
				if (!validacao.Sucesso)
				{
					return validacao;
				}

				repository.Remove(id);

				_ = await Commit();
			}
			catch (Exception)
			{
				return new SingleResult<BeneficiarioCliente>(MensagensNegocio.MSG07);
			}

			return new ExclusaoResult<BeneficiarioCliente>();
		}

		private void HydrateValues(BeneficiarioCliente target, BeneficiarioCliente source)
		{
			target.Codigo = source.Codigo;
		}
	}
}
