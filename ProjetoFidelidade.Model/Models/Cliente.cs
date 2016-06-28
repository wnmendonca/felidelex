using System;

namespace ProjetoFidelidade.Model
{
    public class Cliente
    {
        public Cliente()
        {
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public Nullable<DateTime> DataCadastro { get; set; }
        public DateTime DataInclusao { get; set; }
        public Nullable<DateTime> DataAlteracao { get; set; }
    }
}
