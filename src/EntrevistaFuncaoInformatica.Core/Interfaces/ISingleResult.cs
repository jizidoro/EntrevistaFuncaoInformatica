using EntrevistaFuncaoInformatica.Domain.Bases;
using EntrevistaFuncaoInformatica.Domain.Interfaces;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface ISingleResult<TEntity> : IResult
		where TEntity : IEntity
	{	
		TEntity Data { get; set; }
	}
}
