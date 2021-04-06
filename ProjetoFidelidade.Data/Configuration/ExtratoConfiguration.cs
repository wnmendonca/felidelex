using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class ExtratoConfiguration : EntityTypeConfiguration<Extrato>
    {
        public ExtratoConfiguration()
        {
            //PK
            HasKey(t => t.Id);

            //Properties
            Property(t => t.ClienteEstabelecimentoId)
                .IsRequired();

            //Mappings
            ToTable("Extrato");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.ClienteEstabelecimentoId).HasColumnName("ClienteEstabelecimentoId");
            Property(t => t.Saldo).HasColumnName("Saldo");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            //Relationships
        }
    }
}
