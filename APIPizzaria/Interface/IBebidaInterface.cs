using APIPizzaria.Models;
using APIPizzaria.Services;

namespace APIPizzaria.Interface
{
    public interface IBebidaInterface
    {
        Task<List<BebidaService>> GetAllBebidas();
        Task<List<BebidaService>> CreateBebida(BebidaModel novaBebida);
        Task<BebidaService> GetBebidaById(int id);
        Task<List<BebidaService>> UpdateBebida(BebidaModel updateBebida);
        Task<List<BebidaService>> DeleteBebida(int id);
    }
}
