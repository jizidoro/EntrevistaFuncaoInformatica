using EntrevistaFuncaoInformatica.Infrastructure.Data;
using EntrevistaFuncaoInformatica.Infrastructure.Bases;
using EntrevistaFuncaoInformatica.Core.Repositories;
using EntrevistaFuncaoInformatica.Domain.Models;
using EntrevistaFuncaoInformatica.Core.Interfaces;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EntrevistaFuncaoInformatica.Core.Models.Results;
using EntrevistaFuncaoInformatica.Core.Messages;
using System;

namespace EntrevistaFuncaoInformatica.Infrastructure.Repositories
{
	public class BeneficiarioClienteRepository : Repository<BeneficiarioCliente>, IBeneficiarioClienteRepository
	{
		private readonly EntrevistaFuncaoInformaticaContext _context;
		public BeneficiarioClienteRepository(EntrevistaFuncaoInformaticaContext context)
			: base(context)
		{
			this._context = context ??
							throw new ArgumentNullException(nameof(context));
		}

		public async Task<ISingleResult<BeneficiarioCliente>> RegistroComMesmoCodigo(int id, string codigo)
		{
			var existe = await Db.BeneficiarioClientes
				.Where(p => p.Id != id && p.Codigo.Equals(codigo))
				.AnyAsync();

			return existe ? new SingleResult<BeneficiarioCliente>(MensagensNegocio.MSG08) : new SingleResult<BeneficiarioCliente>();
		}
	}
}