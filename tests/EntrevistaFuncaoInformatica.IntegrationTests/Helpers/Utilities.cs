using System.Reflection;
using EntrevistaFuncaoInformatica.Domain.Models;
using EntrevistaFuncaoInformatica.Infrastructure.Data;
using EntrevistaFuncaoInformatica.Infrastructure.Extensions;

namespace EntrevistaFuncaoInformatica.IntegrationTests.Helpers
{
	public static class Utilities
	{
		private const string JSON_PATH = "EntrevistaFuncaoInformatica.Infrastructure.SeedData";

		#region snippet1
		public static void InitializeDbForTests(EntrevistaFuncaoInformaticaContext db)
		{
			var assembly = Assembly.GetAssembly(typeof(JsonUtilities));
						
			db.ClienteSistemas.AddRange(JsonUtilities.GetListFromJson<ClienteSistema>(assembly.GetManifestResourceStream($"{JSON_PATH}.ClienteSistema.json")));
			
			db.SaveChanges();
		}

		#endregion
	}
}