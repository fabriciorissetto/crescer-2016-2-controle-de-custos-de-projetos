﻿using ControleCustos.Dominio.UsuarioDominio.Enum;
using System.ComponentModel.DataAnnotations;

namespace ControleCustos.Dominio.UsuarioDominio.Classe
{
    public class Usuario
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public Permissao Permissao { get; set; }
    }
}
