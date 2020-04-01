using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using EntrevistaFuncaoInformatica.Application.Interfaces;
using EntrevistaFuncaoInformatica.Core.Interfaces;
using EntrevistaFuncaoInformatica.Core.Repositories;
using EntrevistaFuncaoInformatica.Domain.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Application.Services
{
	public class BeneficiarioClienteAppService : AppService, IBeneficiarioClienteAppService
	{
		private readonly IBeneficiarioClienteRepository _repository;
		private readonly IBeneficiarioClienteService _service;

		public BeneficiarioClienteAppService(IBeneficiarioClienteRepository _repository, IBeneficiarioClienteService _service, IMapper _mapper)
			: base(_mapper)
		{
			this._repository = _repository;
			this._service = _service;
		}

		public async Task<IListResultDto<BeneficiarioClienteDto>> Listar()
		{
			var lista = await Task.Run(() => _repository.GetAll()
				.ProjectTo<BeneficiarioClienteDto>(Mapper.ConfigurationProvider)
				.ToList());

			return new ListResultDto<BeneficiarioClienteDto>(lista);
		}

		public async Task<ISingleResultDto<BeneficiarioClienteDto>> Obter(int id)
		{
			var entity = await _repository.GetById(id);
			var dto = Mapper.Map<BeneficiarioClienteDto>(entity);
			return new SingleResultDto<BeneficiarioClienteDto>(dto);
		}

		public async Task<ISingleResultDto<EntityDto>> Incluir(BeneficiarioClienteIncluirDto dto)
		{
			var evento = Mapper.Map<BeneficiarioCliente>(dto);

			var result = await _service.Incluir(evento);

			var resultDto = new SingleResultDto<EntityDto>(result);
			resultDto.SetData(result, Mapper);

			return resultDto;
		}

		public async Task<ISingleResultDto<EntityDto>> Editar(BeneficiarioClienteEditarDto dto)
		{
			var evento = Mapper.Map<BeneficiarioCliente>(dto);

			var result = await _service.Editar(evento);

			var resultDto = new SingleResultDto<EntityDto>(result);
			resultDto.SetData(result, Mapper);

			return resultDto;
		}

		public async Task<ISingleResultDto<EntityDto>> Excluir(int id)
		{
			var result = await _service.Excluir(id);

			var resultDto = new SingleResultDto<EntityDto>(result);
			resultDto.SetData(result, Mapper);

			return resultDto;
		}
	}
}
