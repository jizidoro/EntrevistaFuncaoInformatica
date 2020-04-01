using EntrevistaFuncaoInformatica.Application.Dtos;
using EntrevistaFuncaoInformatica.Domain.Bases;
using EntrevistaFuncaoInformatica.Domain.Models;
using AutoMapper;

namespace EntrevistaFuncaoInformatica.Application.AutoMapper
{
	public class DtoToDomainMappingProfile : Profile
    {
		public DtoToDomainMappingProfile()
		{
            CreateMap<ClienteSistemaIncluirDto, ClienteSistema>();
        }
    }
}
