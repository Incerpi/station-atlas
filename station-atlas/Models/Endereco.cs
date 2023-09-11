using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace station_atlas.Models
{
    [Table("ENDERECO")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Complemento { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set;}

    }
}
