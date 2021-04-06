using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class ClienteEstabelecimentoRepository : RepositoryBase<ClienteEstabelecimento>, IClienteEstabelecimentoRepository
    {
        public ClienteEstabelecimentoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IClienteEstabelecimentoRepository : IRepository<ClienteEstabelecimento>
    { 
        
    }
}
