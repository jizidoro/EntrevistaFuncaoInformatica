using EntrevistaFuncaoInformatica.Core.Interfaces;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Core.Bases
{
	public class Service : IService
	{
		private readonly IUnitOfWork _uow;

		public Service(IUnitOfWork uow)
		{
			_uow = uow;
		}

		public async Task<bool> Commit()
		{
			if (await _uow.Commit())
			{
				return true;
			}

			return false;
		}
	}
}
