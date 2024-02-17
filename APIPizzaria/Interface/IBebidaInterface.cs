using APIPizzaria.Models;
using APIPizzaria.Services;

namespace APIPizzaria.Interface
{
    public interface IBebidaInterface
    {
        Task<ServiceResponse<List<BebidaModel>>> GetAllBebidas();
        Task<ServiceResponse<List<BebidaModel>>> CreateBebida(BebidaModel novaBebida);
        Task<ServiceResponse<BebidaModel>> GetBebidaById(int id);
        Task<ServiceResponse<List<BebidaModel>>> UpdateBebida(BebidaModel updateBebida);
        Task<ServiceResponse<List<BebidaModel>>> DeleteBebida(int id);
        Task<ServiceResponse<List<BebidaModel>>> InativaBebida(int id);

    }
}
