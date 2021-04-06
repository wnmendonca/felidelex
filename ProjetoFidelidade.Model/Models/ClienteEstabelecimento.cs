using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFidelidade.Model
{
    public class ClienteEstabelecimento
    {
        public ClienteEstabelecimento() {} 

        public ClienteEstabelecimento(int _clienteId, int _estabelecimentoId)
        {
            ClienteId = _clienteId;
            EstabelecimentoId = _estabelecimentoId;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EstabelecimentoId { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual Cliente Cliente { get; private set; }
        public virtual Estabelecimento Estabelecimento { get; private set; }
        public virtual ICollection<Transacao> Transacao { get; private set; }
        public virtual ICollection<Extrato> Extrato { get; private set; }
    }
}
