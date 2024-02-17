using APIPizzaria.Data;
using APIPizzaria.Interface;
using APIPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPizzaria.Services
{
    public class PizzaService : IPizzaInterface
    {
        private readonly DarpinosDbContext _context;

        public PizzaService(DarpinosDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<PizzaModel>>> GetAllPizza()
        {
            ServiceResponse<List<PizzaModel>> serviceResponse = new ServiceResponse<List<PizzaModel>>();

            try
            {
                serviceResponse.Dados = await _context.Pizza.ToListAsync();

                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<PizzaModel>> GetPizzaById(int id)
        {
            ServiceResponse<PizzaModel> serviceResponse = new ServiceResponse<PizzaModel>();

            try
            {
                PizzaModel pizza = await _context.Pizza.FirstOrDefaultAsync(x => x.Id == id);

                if (id == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Nenhum dado encontrado";
                    serviceResponse.Status = false;
                }

                serviceResponse.Dados = pizza;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<PizzaModel>>> CreatePizza(PizzaModel novaPizza)
        {
            ServiceResponse<List<PizzaModel>> serviceResponse = new ServiceResponse<List<PizzaModel>>();

            try
            {
                if (novaPizza == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados!";
                    serviceResponse.Status = false;
                }

                _context.Add(novaPizza);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Pizza.ToListAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<PizzaModel>>> UpdatePizza(PizzaModel updatePizza)
        {
            ServiceResponse<List<PizzaModel>> serviceResponse = new ServiceResponse<List<PizzaModel>>();

            try
            {
                PizzaModel pizza = await _context.Pizza.AsNoTracking().FirstOrDefaultAsync(x => x.Id == updatePizza.Id);

                if (updatePizza == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não encontrado!";
                    serviceResponse.Status = false;
                }

                _context.Pizza.Update(updatePizza);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Pizza.ToListAsync();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;


        }

        public async Task<ServiceResponse<List<PizzaModel>>> DeletePizza(int id)
        {
            ServiceResponse<List<PizzaModel>> serviceResponse = new ServiceResponse<List<PizzaModel>>();

            try
            {
                PizzaModel pizza = await _context.Pizza.FirstOrDefaultAsync(x => x.Id == id);

                if (id == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não encontrado!";
                    serviceResponse.Status = false;
                }

                _context.Pizza.Remove(pizza);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Pizza.OrderBy(x => x.Id).ToListAsync();

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<PizzaModel>>> InativaPizza(int id)
        {
            ServiceResponse<List<PizzaModel>> serviceResponse = new ServiceResponse<List<PizzaModel>>();

            try
            {
                PizzaModel pizza = await _context.Pizza.FirstOrDefaultAsync(x => x.Id == id);

                if (pizza == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não encontrado!";
                    serviceResponse.Status = false;
                }

                pizza.Preço = 0.0;

                _context.Pizza.Update(pizza);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = await _context.Pizza.ToListAsync();
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
