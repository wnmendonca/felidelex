using ProjetoFidelidade.Model;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class TipoEstabelecimentoConfiguration : EntityTypeConfiguration<TipoEstabelecimento>
    {
        public TipoEstabelecimentoConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Descricao)
                .HasMaxLength(100)
                .IsRequired();

            // Mappings
            ToTable("TipoEstabelecimento");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Descricao).HasColumnName("Descricao");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
        }
    }
}
