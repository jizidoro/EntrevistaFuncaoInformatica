using EntrevistaFuncaoInformatica.Core.Interfaces;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.Infrastructure.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly EntrevistaFuncaoInformaticaContext context;

		public UnitOfWork(EntrevistaFuncaoInformaticaContext context)
		{
			this.context = context;
		}

		public async Task<bool> Commit()
		{
			return await context.SaveChangesAsync() > 0;
		}

		public void Dispose()
		{
			context.Dispose();
		}
	}
}
