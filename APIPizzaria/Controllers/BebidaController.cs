using APIPizzaria.Interface;
using APIPizzaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPizzaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidaController : ControllerBase
    {
        private readonly IBebidaInterface _bebidaInterface;

        public BebidaController(IBebidaInterface bebidaInterface)
        {
            _bebidaInterface = bebidaInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<BebidaModel>>>> GetAllBebidas()
        {
            var getBebida = await _bebidaInterface.GetAllBebidas();
            return Ok(getBebida);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<BebidaModel>>> GetBebidaById(int id)
        {
            var getBebidaById = await _bebidaInterface.GetBebidaById(id);
            return Ok(getBebidaById);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<BebidaModel>>>> CreateBebida(BebidaModel bebida)
        {
            var newBebida = await _bebidaInterface.CreateBebida(bebida);
            return Ok(newBebida);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<BebidaModel>>>> UpdateBebida(BebidaModel bebida)
        {
            var upBebida = await _bebidaInterface.UpdateBebida(bebida);
            return Ok(upBebida);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<BebidaModel>>>> DeleteBebida(int id)
        {
            var delBebida = await _bebidaInterface.DeleteBebida(id);
            return Ok(delBebida);
        }

        [HttpPut("InativarBebida")]
        public async Task<ActionResult<ServiceResponse<List<BebidaModel>>>> InativaBebida(int id)
        {
            var inatBebida = await _bebidaInterface.InativaBebida(id);
            return Ok(inatBebida);
        }
    }
}
