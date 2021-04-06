using System;

namespace ProjetoFidelidade.Model
{
    public class EstabelecimentoAparelho
    {
        public EstabelecimentoAparelho() { }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Identificador { get; set; }
        public int EstabelecimentoId { get; set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual Estabelecimento Estabelecimento { get; set; }
    }
}
