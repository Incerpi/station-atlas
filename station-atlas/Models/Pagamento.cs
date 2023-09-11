using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace station_atlas.Models
{
    [Table("PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        public int IdPagamento { get; set; }

        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        public float Valor { get; set; }

    }
}
