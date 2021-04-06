using System;

namespace ProjetoFidelidade.Model
{
    public class RedeEstabelecimento
    {
        public RedeEstabelecimento() { }

        public int Id { get; set; }
        public int AdminId { get; set; }
        public int EstabelecimentoId { get; set; }
        public bool FlAtivo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
