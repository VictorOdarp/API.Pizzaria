using APIPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPizzaria.Data
{
    public class DarpinosDbContext : DbContext
    {

        public DarpinosDbContext(DbContextOptions<DarpinosDbContext> options) : base(options)
        {

        }

        public DbSet<PizzaModel> Pizza { get; set; }
        public DbSet<BebidaModel> Bebida { get; set; }
    }
}
