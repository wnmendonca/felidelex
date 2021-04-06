using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class TipoTransacaoRepository : RepositoryBase<TipoTransacao>, ITipoTransacaoRepository
    {
        public TipoTransacaoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ITipoTransacaoRepository : IRepository<TipoTransacao>
    {

    }
}
