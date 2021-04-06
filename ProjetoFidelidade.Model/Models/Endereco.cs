using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Model
{
    public class Endereco
    {
        public Endereco() { }

        public Endereco(string _logradouro, string _cep, string _bairro, string _cidade, string _estado, string _numero, string _complemento)
        {
            Logradouro = _logradouro;
            CEP = _cep;
            Bairro = _bairro;
            Cidade = _cidade;
            Estado = _estado;
            Numero = _numero;
            Complemento = _complemento;
            FlAtivo = true;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public bool FlAtivo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual ICollection<Estabelecimento> Estabelecimento { get; private set; }
        public virtual ICollection<Admin> Admin { get; set; }
    }
}