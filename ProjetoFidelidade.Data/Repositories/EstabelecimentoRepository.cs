using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class EstabelecimentoRepository : RepositoryBase<Estabelecimento>, IEstabelecimentoRepository
    {
        public EstabelecimentoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Estabelecimento GetByCNPJ(string cnpj)
        {
            var estabelecimento = this.DbContext.Estabelecimento.Where(c => c.CNPJ == cnpj).FirstOrDefault();

            return estabelecimento;
        }

        public override void Update(Estabelecimento entity)
        {
            entity.DataAlteracao = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IEstabelecimentoRepository : IRepository<Estabelecimento>
    {
        Estabelecimento GetByCNPJ(string cnpj);
    }
}
