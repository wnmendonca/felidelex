using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFidelidade.Model
{
    public class Transacao
    {
        public Transacao() { }

        public Transacao(int _clienteEstabelecimentoId, string _descricao, decimal _valor, int _tipoTransacaoId, DateTime _dataTransacao)
        {
            ClienteEstabelecimentoId = _clienteEstabelecimentoId;
            Descricao = _descricao;
            Valor = _valor;
            TipoTransacaoId = _tipoTransacaoId;
            DataTransacao = _dataTransacao;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public int ClienteEstabelecimentoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int TipoTransacaoId { get; set; }
        public bool FlBloqueado { get; set; }
        public bool FlAtivo { get; set; }
        public DateTime DataTransacao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual ClienteEstabelecimento ClienteEstabelecimento { get; set; }
        public virtual TipoTransacao TipoTransacao { get; set; }
    }
}
