using APIPizzaria.Enums.Pizza;
using System.ComponentModel.DataAnnotations;

namespace APIPizzaria.Models
{
    public class PizzaModel
    {
        [Key]
        public int Id { get; set; }
        public TamanhoEnum Tamanho { get; set; }
        public SaborEnum Sabor { get; set; }
        public BordaEnum Borda { get; set; }
        public double Preço { get; set; }
    }
}
