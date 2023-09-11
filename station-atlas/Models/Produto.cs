using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace station_atlas.Models
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Preco { get; set; }

        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public virtual Categoria? Categoria { get; set; }

    }
}

