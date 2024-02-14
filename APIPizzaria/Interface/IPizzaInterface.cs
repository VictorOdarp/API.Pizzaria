using APIPizzaria.Models;
using APIPizzaria.Services;

namespace APIPizzaria.Interface
{
    public interface IPizzaInterface
    {
        Task<ServiceResponse<List<PizzaModel>>> GetAllPizza();
        Task<ServiceResponse<List<PizzaModel>>> CreatePizza(PizzaModel novaPizza);
        Task<ServiceResponse<PizzaModel>> GetPizzaById(int id);
        Task<ServiceResponse<List<PizzaModel>>> UpdatePizza(PizzaModel updatePizza);
        Task<ServiceResponse<List<PizzaModel>>> DeletePizza(int id);
        Task<ServiceResponse<List<PizzaModel>>> InativaPizza(int id);
    }
}
