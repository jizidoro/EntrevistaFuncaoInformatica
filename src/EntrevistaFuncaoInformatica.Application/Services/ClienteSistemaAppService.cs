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
	public class ClienteSistemaAppService : AppService, IClienteSistemaAppService
	{
		private readonly IClienteSistemaRepository _repository;
		private readonly IClienteSistemaService _service;

		public ClienteSistemaAppService(IClienteSistemaRepository _repository, IClienteSistemaService _service, IMapper _mapper)
			: base(_mapper)
		{
			this._repository = _repository;
			this._service = _service;
		}

		public async Task<IListResultDto<ClienteSistemaDto>> Listar()
		{
			var lista = await Task.Run(() => _repository.GetAll()
				.ProjectTo<ClienteSistemaDto>(Mapper.ConfigurationProvider)
				.ToList());

			return new ListResultDto<ClienteSistemaDto>(lista);
		}

		public async Task<ISingleResultDto<ClienteSistemaDto>> Obter(int id)
		{
			var entity = await _repository.GetById(id);
			var dto = Mapper.Map<ClienteSistemaDto>(entity);
			return new SingleResultDto<ClienteSistemaDto>(dto);
		}

		public async Task<ISingleResultDto<EntityDto>> Incluir(ClienteSistemaIncluirDto dto)
		{
			var evento = Mapper.Map<ClienteSistema>(dto);

			var result = await _service.Incluir(evento);

			var resultDto = new SingleResultDto<EntityDto>(result);
			resultDto.SetData(result, Mapper);

			return resultDto;
		}

		public async Task<ISingleResultDto<EntityDto>> Editar(ClienteSistemaEditarDto dto)
		{
			var evento = Mapper.Map<ClienteSistema>(dto);

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
