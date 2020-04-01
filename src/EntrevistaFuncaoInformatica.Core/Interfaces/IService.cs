using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Interfaces
{
	public interface IService
    {
		Task<bool> Commit();
	}
}
