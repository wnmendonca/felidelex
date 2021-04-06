using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class ExtratoRepository : RepositoryBase<Extrato>, IExtratoRepository
    {
        public ExtratoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<Extrato> GetExtrato(int clienteEstabelecimentoId)
        {
            return this.DbContext.Extrato.Where(x => x.ClienteEstabelecimentoId == clienteEstabelecimentoId);
        }
    }

    public interface IExtratoRepository : IRepository<Extrato>
    {
        IEnumerable<Extrato> GetExtrato(int clienteEstabelecimentoId);
    }
}
