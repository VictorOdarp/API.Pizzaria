using APIPizzaria.Interface;
using APIPizzaria.Models;
using APIPizzaria.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPizzaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaInterface _pizzaInterface;

        public PizzaController(IPizzaInterface pizzaInterface)
        {
            _pizzaInterface = pizzaInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<PizzaModel>>>> GetAllPizza()
        {
            var pizza = await _pizzaInterface.GetAllPizza();
            return Ok(pizza);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<PizzaModel>>> GetPizzaById(int id)
        {
            var pizzaById = await _pizzaInterface.GetPizzaById(id);
            return Ok(pizzaById);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<PizzaModel>>>> CreatePizza(PizzaModel novaPizza)
        {
            var newPizza = await _pizzaInterface.CreatePizza(novaPizza);
            return Ok(newPizza);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<PizzaModel>>>> UpdatePizza(PizzaModel pizzaeditada)
        {
            var upPizza = _pizzaInterface.UpdatePizza(pizzaeditada);
            return Ok(upPizza);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<PizzaModel>>>> DeletePizza(int id)
        {
            var delPizza = _pizzaInterface.DeletePizza(id);
            return Ok(delPizza);
        }

        [HttpPut("InativaPizza")]
        public async Task<ActionResult<ServiceResponse<List<PizzaModel>>>> InativaPizza(int id)
        {
            var InativaPizza = _pizzaInterface.InativaPizza(id);
            return Ok(InativaPizza);
        }
    }
}
