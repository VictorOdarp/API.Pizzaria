using APIPizzaria.Enums.Bebida;
using System.ComponentModel.DataAnnotations;

namespace APIPizzaria.Models
{
    public class BebidaModel
    {
        [Key]
        public int Id { get; set; }
        public NomeEnum Nome { get; set; }
        public TamanhoEnum Tamanho { get; set; }
        public double Preço { get; set; }
    }
}
