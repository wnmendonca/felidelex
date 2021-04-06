using ProjetoFidelidade.Data.Configuration;
using ProjetoFidelidade.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoFidelidade.Data
{
    public class Entities : DbContext
    {
        public Entities() : base("dbConn") { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }
        public DbSet<EstabelecimentoAparelho> EstabelecimentoAparelho { get; set; }
        public DbSet<RedeEstabelecimento> RedeEstabelecimento { get; set; }
        public DbSet<TipoEstabelecimento> TipoEstabelecimento { get; set; }
        public DbSet<ClienteEstabelecimento> ClienteEstabelecimento { get; set; }
        public DbSet<Extrato> Extrato { get; set; }
        public DbSet<TipoTransacao> TipoTransacao { get; set; }
        public DbSet<Transacao> Transacao { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(c => c.IsUnicode(false));

            // Table mappings
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new EstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new EstabelecimentoAparelhoConfiguration());
            modelBuilder.Configurations.Add(new RedeEstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new TipoEstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new ClienteEstabelecimentoConfiguration());
            modelBuilder.Configurations.Add(new ExtratoConfiguration());
            modelBuilder.Configurations.Add(new TipoTransacaoConfiguration());
            modelBuilder.Configurations.Add(new TransacaoConfiguration());
        }
    }
}
