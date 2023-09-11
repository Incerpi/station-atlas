using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace station_atlas.Models
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Sobrenome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        [ForeignKey("Endereco")]
        public int IdEndereco { get; set; }
        public virtual Endereco? Endereco { get; set; }
    }
}