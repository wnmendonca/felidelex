using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class TransacaoConfiguration : EntityTypeConfiguration<Transacao>
    {
        public TransacaoConfiguration()
        {
            //PK
            HasKey(t => t.Id);

            //Properties
            Property(t => t.ClienteEstabelecimentoId)
                .IsRequired();
            Property(t => t.Descricao)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Valor)
                .IsRequired();
            Property(t => t.TipoTransacaoId)
                .IsRequired();
            Property(t => t.FlBloqueado)
                .IsRequired();
            Property(t => t.FlAtivo)
                .IsRequired();
            Property(t => t.DataTransacao)
                .IsRequired();

            //Mappings
            ToTable("Transacao");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.ClienteEstabelecimentoId).HasColumnName("ClienteEstabelecimentoId");
            Property(t => t.Descricao).HasColumnName("Descricao");
            Property(t => t.Valor).HasColumnName("Valor");
            Property(t => t.TipoTransacaoId).HasColumnName("TipoTransacaoId");
            Property(t => t.FlBloqueado).HasColumnName("FlBloqueado");
            Property(t => t.FlAtivo).HasColumnName("FlAtivo");
            Property(t => t.DataTransacao).HasColumnName("DataTransacao");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            //Relationships
        }
    }
}
