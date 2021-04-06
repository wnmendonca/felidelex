using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFidelidade.Model
{
    public class TipoTransacao
    {
        public TipoTransacao() { }

        public TipoTransacao(string _descricao)
        {
            Descricao = _descricao;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public ICollection<Transacao> Transacao { get; set; }
    }
}
