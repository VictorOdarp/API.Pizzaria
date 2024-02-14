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

        public Task<ServiceResponse<List<BebidaModel>>> CreateBebida(BebidaModel novaBebida)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<BebidaModel>>> DeleteBebida(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<BebidaModel>>> GetAllBebidas()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BebidaModel>> GetBebidaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<BebidaModel>>> UpdateBebida(BebidaModel updateBebida)
        {
            throw new NotImplementedException();
        }
    }
}
