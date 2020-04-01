using EntrevistaFuncaoInformatica.Application.Extensions;
using EntrevistaFuncaoInformatica.Application.Interfaces;
using EntrevistaFuncaoInformatica.Domain.Bases;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Application.Bases
{
	public class AppService : IAppService
	{
		private readonly IMapper mapper;

		public IMapper Mapper 
		{ 
			get
			{
				return mapper;
			}
		}
		
		public AppService(IMapper mapper)
		{
			this.mapper = mapper;
		}
	}
}
