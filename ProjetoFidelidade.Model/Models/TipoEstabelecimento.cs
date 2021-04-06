using System;
using System.Collections.Generic;

namespace ProjetoFidelidade.Model
{
    public class TipoEstabelecimento
    {
        public TipoEstabelecimento() { }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual ICollection<Estabelecimento> Estabelecimento { get; private set; }
    }
}