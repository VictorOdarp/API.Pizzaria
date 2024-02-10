using APIPizzaria.Data;
using APIPizzaria.Interface;
using APIPizzaria.Models;

namespace APIPizzaria.Services
{
    public class BebidaService : IBebidaInterface
    {
        private readonly DarpinosDbContext _context;

        public BebidaService(DarpinosDbContext context)
        {
            _context = context;
        }
        public Task<List<BebidaService>> CreateBebida(BebidaModel novaBebida)
        {
            throw new NotImplementedException();
        }

        public Task<List<BebidaService>> DeleteBebida(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BebidaService>> GetAllBebidas()
        {
            throw new NotImplementedException();
        }

        public Task<BebidaService> GetBebidaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BebidaService>> UpdateBebida(BebidaModel updateBebida)
        {
            throw new NotImplementedException();
        }
    }
}
