using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class TransacaoRepository : RepositoryBase<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public ICollection<Transacao> GetTransacao(int clienteEstabelecimentoId)
        {
            return this.DbContext.Transacao.Where(x => x.ClienteEstabelecimentoId == clienteEstabelecimentoId).ToList();
        }

        public void CreateTransacao(Transacao transacao)
        {
            this.DbContext.Transacao.Add(transacao);
        }

        public void UpdateTransacao(Transacao transacao)
        {
            this.DbContext.Transacao.Attach(transacao);
            this.DbContext.Entry(transacao).State = EntityState.Modified;
        }
    }

    public interface ITransacaoRepository : IRepository<Transacao>
    {
        ICollection<Transacao> GetTransacao(int clienteEstabelecimentoId);
        void CreateTransacao(Transacao transacao);
        void UpdateTransacao(Transacao transacao);
    }
}
