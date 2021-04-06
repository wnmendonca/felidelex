using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class TipoTransacaoConfiguration : EntityTypeConfiguration<TipoTransacao>
    {
        public TipoTransacaoConfiguration()
        {
            //PK
            HasKey(t => t.Id);

            //Properties
            Property(t => t.Descricao)
                .HasMaxLength(100)
                .IsRequired();

            //Mappings
            ToTable("TipoTransacao");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Descricao).HasColumnName("Descricao");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            //Relationships
        }
    }
}
