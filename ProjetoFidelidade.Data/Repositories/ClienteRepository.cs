using ProjetoFidelidade.Data.Infrastructure;
using ProjetoFidelidade.Model;
using System;
using System.Linq;

namespace ProjetoFidelidade.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Cliente GetClienteByCPF(string cpf)
        {
            var cliente = this.DbContext.Clientes.Where(c => c.CPF == cpf).FirstOrDefault();

            return cliente;
        }

        public override void Update(Cliente entity)
        {
            entity.DataAlteracao = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetClienteByCPF(string cpf);
    }
}
