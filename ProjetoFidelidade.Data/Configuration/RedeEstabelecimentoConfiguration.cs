using ProjetoFidelidade.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class RedeEstabelecimentoConfiguration : EntityTypeConfiguration<RedeEstabelecimento>
    {
        public RedeEstabelecimentoConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.AdminId)
                .IsRequired();
            Property(t => t.EstabelecimentoId)
                .IsRequired();
            Property(t => t.FlAtivo)
                .IsRequired();

            // Mappings
            ToTable("RedeEstabelecimento");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.AdminId).HasColumnName("AdminId");
            Property(t => t.EstabelecimentoId).HasColumnName("EstabelecimentoId");
            Property(t => t.FlAtivo).HasColumnName("FlAtivo");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
            HasRequired(r => r.Estabelecimento)
                .WithMany(e => e.RedeEstabelecimento)
                .HasForeignKey(r => r.EstabelecimentoId);

            HasRequired(r => r.Admin)
                .WithMany(a => a.RedeEstabelecimento)
                .HasForeignKey(r => r.AdminId);
        }
    }
}
