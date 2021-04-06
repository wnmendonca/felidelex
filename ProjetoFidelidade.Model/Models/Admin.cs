using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Model
{
    public class Admin
    {
        public Admin() { }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public string DddCelular { get; private set; }
        public string Celular { get; private set; }
        public string DddTelefoneComercial { get; private set; }
        public string TelefoneComercial { get; private set; }
        public string Email { get; private set; }
        public int EnderecoId { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual Endereco Endereco { get; private set; }
        public virtual ICollection<RedeEstabelecimento> RedeEstabelecimento { get; set; }
    }
}
