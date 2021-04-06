using System;

namespace ProjetoFidelidade.Web.Models.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}