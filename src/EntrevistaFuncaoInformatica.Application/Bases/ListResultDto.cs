using EntrevistaFuncaoInformatica.Application.Interfaces;
using System.Collections.Generic;

namespace EntrevistaFuncaoInformatica.Application.Bases
{
	public class ListResultDto<T> : IListResultDto<T>
		where T: Dto
    {
		public ListResultDto(IEnumerable<T> list)
		{
			this.Data = list;
		}

		public IEnumerable<T> Data { get; set; }
	}
}
