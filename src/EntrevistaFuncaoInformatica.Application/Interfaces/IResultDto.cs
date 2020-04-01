using EntrevistaFuncaoInformatica.Core.Interfaces;
using System.Collections.Generic;

namespace EntrevistaFuncaoInformatica.Application.Interfaces
{
	public interface IResultDto : IResult		
	{
        string Campo { get; set; }
        IList<string> Mensagens { get; set; }
	}
}
