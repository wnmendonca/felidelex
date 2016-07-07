using ProjetoFidelidade.Data.Configuration;
using ProjetoFidelidade.Model;
using System.Data.Entity;

namespace ProjetoFidelidade.Data
{
    public class Entities : DbContext
    {
        public Entities() : base("dbConn") { }

        public DbSet<Cliente> Clientes { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteConfiguration());
        }
    }
}
