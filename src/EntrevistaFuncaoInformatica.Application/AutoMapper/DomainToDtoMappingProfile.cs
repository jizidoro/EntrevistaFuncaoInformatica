using EntrevistaFuncaoInformatica.Application.Bases;
using EntrevistaFuncaoInformatica.Application.Dtos;
using EntrevistaFuncaoInformatica.Domain.Bases;
using EntrevistaFuncaoInformatica.Domain.Models;
using AutoMapper;

namespace EntrevistaFuncaoInformatica.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Entity, EntityDto>();
            

            CreateMap<ClienteSistema, ClienteSistemaEditarDto>();
            CreateMap<ClienteSistema, ClienteSistemaDto>();
        }
    }
}
