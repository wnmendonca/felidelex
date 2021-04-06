using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFidelidade.Model
{
    public class Extrato
    {
        public Extrato() { }

        public Extrato(int _clienteEstabelecimentoId, decimal _saldo)
        {
            ClienteEstabelecimentoId = _clienteEstabelecimentoId;
            Saldo = _saldo;
            DataInclusao = DateTime.Now;
        }

        public int Id { get; set; }
        public int ClienteEstabelecimentoId { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public virtual ClienteEstabelecimento ClienteEstabelecimento { get; set; }
    }
}