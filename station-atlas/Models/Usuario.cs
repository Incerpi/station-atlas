﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace station_atlas.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set;}

        [Required]
        public string Cpf { get; set;}

        [Required]
        public string Senha { get; set;}
    }
}
