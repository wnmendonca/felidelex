using System;

namespace ProjetoFidelidade.Model
{
    public sealed class Cliente
    {
        public Cliente()
        {
            DataInclusao = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string DddCelular { get; private set; }
        public string Celular { get; private set; }
        public Nullable<DateTime> DataCadastro { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public Nullable<DateTime> DataAlteracao { get; set; }
    }
}
