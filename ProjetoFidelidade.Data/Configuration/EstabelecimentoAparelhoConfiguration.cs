using ProjetoFidelidade.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class EstabelecimentoAparelhoConfiguration : EntityTypeConfiguration<EstabelecimentoAparelho>
    {
        public EstabelecimentoAparelhoConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Modelo)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Identificador)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.EstabelecimentoId)
                .IsRequired();

            // Mappings
            ToTable("EstabelecimentoAparelho");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Modelo).HasColumnName("Modelo");
            Property(t => t.Identificador).HasColumnName("Identificador");
            Property(t => t.EstabelecimentoId).HasColumnName("EstabelecimentoId");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
            HasRequired(ea => ea.Estabelecimento)
                .WithMany(e => e.EstabelecimentoAparelho)
                .HasForeignKey(ea => ea.EstabelecimentoId);
        }
    }
}
