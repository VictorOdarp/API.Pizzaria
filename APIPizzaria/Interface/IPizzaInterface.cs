using APIPizzaria.Models;
using APIPizzaria.Services;

namespace APIPizzaria.Interface
{
    public interface IPizzaInterface
    {
        Task<List<PizzaService>> GetAllBebidas();
        Task<List<PizzaService>> CreateBebida(PizzaModel novaPizza);
        Task<PizzaService> GetBebidaById(int id);
        Task<List<PizzaService>> UpdateBebida(PizzaModel updatePizza);
        Task<List<PizzaService>> DeleteBebida(int id);
    }
}
