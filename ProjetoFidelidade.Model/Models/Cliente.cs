using System;

namespace ProjetoFidelidade.Model
{
    public sealed class Cliente
    {
        public Cliente() { }

        public Cliente(string _nome, string _cpf, string _email, string _dddCelular, string _celular, DateTime _dataCadastro)
        {
            Nome = _nome;
            CPF = _cpf;
            Email = _email;
            DddCelular = _dddCelular;
            Celular = _celular;
            DataCadastro = _dataCadastro;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string DddCelular { get; private set; }
        public string Celular { get; private set; }
        public DateTime? DataCadastro { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
