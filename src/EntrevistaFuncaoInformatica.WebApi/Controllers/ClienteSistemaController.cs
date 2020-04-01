using EntrevistaFuncaoInformatica.Application.Dtos;
using EntrevistaFuncaoInformatica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.WebApi.Controllers
{
    public class ClienteSistemaController : ControllerBase
    {
        private readonly IClienteSistemaAppService _ClienteSistemaAppService;

        public ClienteSistemaController(
            IClienteSistemaAppService ClienteSistemaAppService)
        {
            _ClienteSistemaAppService = ClienteSistemaAppService;
        }

        [HttpGet]
        [Route("ClienteSistema")]
        public async Task<IActionResult> Get()
        {
            var result = await _ClienteSistemaAppService.Listar();
            return Ok(result.Data);
        }

        [HttpGet]
        [Route("ClienteSistema/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _ClienteSistemaAppService.Obter(id);

            return Ok(result);
        }

        [Route("ClienteSistema")]
        [HttpPost]
        public async Task<IActionResult> Incluir([FromBody]ClienteSistemaIncluirDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            var result = await _ClienteSistemaAppService.Incluir(dto);

            return Ok(result);

        }
        
        [HttpPut]
        //[Authorize(Policy = "CanWriteClienteSistemaData")]
        [Route("ClienteSistema")]
        public async Task<IActionResult> Put([FromBody]ClienteSistemaEditarDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            var result = await _ClienteSistemaAppService.Editar(dto);

            return Ok(result);
        }

        [HttpDelete]
        //[Authorize(Policy = "CanRemoveClienteSistemaData")]
        [Route("ClienteSistema/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ClienteSistemaAppService.Excluir(id);

            return Ok(result);
        }
    }
}
