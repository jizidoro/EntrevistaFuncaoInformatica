using EntrevistaFuncaoInformatica.Application.Bases;
using System.Collections.Generic;

namespace EntrevistaFuncaoInformatica.Application.Interfaces
{
	public interface IListResultDto<T>
		where T : Dto
	{
		IEnumerable<T> Data { get; set; }
	}
}
