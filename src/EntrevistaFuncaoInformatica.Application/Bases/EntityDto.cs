using EntrevistaFuncaoInformatica.Application.Interfaces;

namespace EntrevistaFuncaoInformatica.Application.Bases
{
	public class EntityDto : Dto, IEntityDto
	{
		public int Id { get; set; }
	}
}
