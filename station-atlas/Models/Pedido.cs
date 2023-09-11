using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace station_atlas.Models
{
    [Table("PEDIDO")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public string FormaEntrega { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public virtual Produto? Produto { get; set; }

        [ForeignKey("Pagamento")]
        public int IdPagamento { get; set; }
        public virtual Pagamento? Pagamento { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente? Cliente { get; set; }

    }

 }
