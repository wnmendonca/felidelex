using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class ClienteEstabelecimentoConfiguration : EntityTypeConfiguration<ClienteEstabelecimento>
    {
        public ClienteEstabelecimentoConfiguration()
        {
            //PK
            HasKey(t => t.Id);

            //Properties
            Property(t => t.ClienteId)
                .IsRequired();
            Property(t => t.EstabelecimentoId)
                .IsRequired();

            //Mappings
            ToTable("ClienteEstabelecimento");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.ClienteId).HasColumnName("ClienteId");
            Property(t => t.EstabelecimentoId).HasColumnName("EstabelecimentoId");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            //Relationships
        }
    }
}
