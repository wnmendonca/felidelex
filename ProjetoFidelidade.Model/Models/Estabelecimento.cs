using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Model
{
    public class Estabelecimento
    {
        public Estabelecimento() { }

        public Estabelecimento(string _cnpj, string _nomeFantasia, string _razaoSocial, Endereco _endereco, int _qtdeAparelhos)
        {
            CNPJ = _cnpj;
            NomeFantasia = _nomeFantasia;
            RazaoSocial = _razaoSocial;
            Endereco = _endereco;
            QtdeAparelhos = _qtdeAparelhos;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; private set; }
        public string CNPJ { get; private set; }
        public string NomeFantasia { get; private set; }
        public string RazaoSocial { get; private set; }
        public int EnderecoId { get; private set; }
        public int TipoEstabelecimentoId { get; set; }
        public int QtdeAparelhos { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual Endereco Endereco { get; private set; }
        public virtual TipoEstabelecimento TipoEstabelecimento { get; set; }
        public virtual ICollection<EstabelecimentoAparelho> EstabelecimentoAparelho { get; set; }
        public virtual ICollection<RedeEstabelecimento> RedeEstabelecimento { get; set; }
        public virtual ICollection<ClienteEstabelecimento> ClienteEstabelecimento { get; set; }
    }
}