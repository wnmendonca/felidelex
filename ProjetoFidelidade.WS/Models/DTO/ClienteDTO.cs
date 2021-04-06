using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFidelidade.WS.Models.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DddCelular { get; set; }
        [Required]
        public string Celular { get; set; }
        public Nullable<DateTime> DataCadastro { get; set; }
    }
}