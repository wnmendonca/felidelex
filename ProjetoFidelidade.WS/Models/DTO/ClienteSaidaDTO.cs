using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFidelidade.WS.Models.DTO
{
    public class ClienteSaidaDTO
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}