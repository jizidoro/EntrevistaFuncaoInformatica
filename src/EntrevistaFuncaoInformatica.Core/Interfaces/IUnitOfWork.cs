using System;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
		Task<bool> Commit();
    }
}
