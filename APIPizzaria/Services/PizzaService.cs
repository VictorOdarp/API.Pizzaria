using APIPizzaria.Data;
using APIPizzaria.Interface;
using APIPizzaria.Models;

namespace APIPizzaria.Services
{
    public class PizzaService : IPizzaInterface
    {
        private readonly DarpinosDbContext _context;

        public PizzaService(DarpinosDbContext context)
        {
            _context = context;
        }  
        public Task<List<PizzaService>> CreateBebida(PizzaModel novaPizza)
        {
            throw new NotImplementedException();
        }

        public Task<List<PizzaService>> DeleteBebida(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PizzaService>> GetAllBebidas()
        {
            throw new NotImplementedException();
        }

        public Task<PizzaService> GetBebidaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PizzaService>> UpdateBebida(PizzaModel updatePizza)
        {
            throw new NotImplementedException();
        }
    }
}
