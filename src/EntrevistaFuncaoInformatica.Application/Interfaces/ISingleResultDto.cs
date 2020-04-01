using EntrevistaFuncaoInformatica.Application.Bases;

namespace EntrevistaFuncaoInformatica.Application.Interfaces
{
	public interface ISingleResultDto<TDto> : IResultDto
		where TDto : Dto
	{
		TDto Data { get; }
	}
}
