using APIPizzaria.Data;
using APIPizzaria.Interface;
using APIPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPizzaria.Services
{
    public class BebidaService : IBebidaInterface
    {
        private readonly DarpinosDbContext _context;

        public BebidaService(DarpinosDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<BebidaModel>>> GetAllBebidas()
        {
            ServiceResponse<List<BebidaModel>> serviceResponse = new ServiceResponse<List<BebidaModel>>();

            try
            {
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }

                serviceResponse.Dados = await _context.Bebida.ToListAsync();
            }
            catch(Exception ex) 
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<BebidaModel>> GetBebidaById(int id)
        {
            ServiceResponse<BebidaModel> serviceResponse = new ServiceResponse<BebidaModel>();

            try
            {
                BebidaModel bebida = await _context.Bebida.FirstOrDefaultAsync(x => x.Id == id);

                if (id == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                    serviceResponse.Status = false;
                }

                serviceResponse.Dados = bebida;
            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<BebidaModel>>> CreateBebida(BebidaModel novaBebida)
        {
            ServiceResponse<List<BebidaModel>> serviceResponse = new ServiceResponse<List<BebidaModel>>();

            try
            {
                _context.Add(novaBebida);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Bebida.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<BebidaModel>>> UpdateBebida(BebidaModel updateBebida)
        {
            ServiceResponse<List<BebidaModel>> serviceResponse = new ServiceResponse<List<BebidaModel>>();

            try
            {
                BebidaModel bebida = await _context.Bebida.FirstOrDefaultAsync(x => x.Id == updateBebida.Id);

                if (bebida == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                    serviceResponse.Status = false;
                }

                _context.Bebida.Update(updateBebida);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Bebida.ToListAsync();
            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<BebidaModel>>> DeleteBebida(int id)
        {
            ServiceResponse<List<BebidaModel>> serviceResponse = new ServiceResponse<List<BebidaModel>>();

            try
            {
                BebidaModel bebida = await _context.Bebida.FirstOrDefaultAsync(x => x.Id == id);

                if (bebida == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Nenhum dado encontrado";
                    serviceResponse.Status = false;
                }

                _context.Bebida.Remove(bebida);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Bebida.ToListAsync();
            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<BebidaModel>>> InativaBebida(int id)
        {
            ServiceResponse<List<BebidaModel>> serviceResponse = new ServiceResponse<List<BebidaModel>>();

            try
            {
                BebidaModel bebida = await _context.Bebida.FirstOrDefaultAsync(x => x.Id == id);

                if (bebida == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Nenhum dado encontrado";
                    serviceResponse.Status = false;
                }

                bebida.Preço = 0.0;

                _context.Bebida.Update(bebida);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Bebida.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }
    }
}
