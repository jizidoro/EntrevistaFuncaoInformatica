using EntrevistaFuncaoInformatica.Application.Dtos;
using EntrevistaFuncaoInformatica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntrevistaFuncaoInformatica.WebApi.Controllers
{
    public class BeneficiarioClienteController : ControllerBase
    {
        private readonly IBeneficiarioClienteAppService _BeneficiarioClienteAppService;

        public BeneficiarioClienteController(
            IBeneficiarioClienteAppService BeneficiarioClienteAppService)
        {
            _BeneficiarioClienteAppService = BeneficiarioClienteAppService;
        }

        [HttpGet]
        [Route("BeneficiarioCliente")]
        public async Task<IActionResult> Get()
        {
            var result = await _BeneficiarioClienteAppService.Listar();
            return Ok(result.Data);
        }

        [HttpGet]
        [Route("BeneficiarioCliente/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _BeneficiarioClienteAppService.Obter(id);

            return Ok(result);
        }

        [Route("BeneficiarioCliente")]
        [HttpPost]
        public async Task<IActionResult> Incluir([FromBody]BeneficiarioClienteIncluirDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            var result = await _BeneficiarioClienteAppService.Incluir(dto);

            return Ok(result);

        }
        
        [HttpPut]
        //[Authorize(Policy = "CanWriteBeneficiarioClienteData")]
        [Route("BeneficiarioCliente")]
        public async Task<IActionResult> Put([FromBody]BeneficiarioClienteEditarDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(dto);
            }

            var result = await _BeneficiarioClienteAppService.Editar(dto);

            return Ok(result);
        }

        [HttpDelete]
        //[Authorize(Policy = "CanRemoveBeneficiarioClienteData")]
        [Route("BeneficiarioCliente/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _BeneficiarioClienteAppService.Excluir(id);

            return Ok(result);
        }
    }
}
