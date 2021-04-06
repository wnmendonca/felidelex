using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Logradouro)
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.CEP)
                .HasMaxLength(8)
                .IsRequired();
            Property(t => t.Bairro)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Cidade)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Estado)
                .HasMaxLength(2)
                .IsRequired();
            Property(t => t.Numero)
                .HasMaxLength(10)
                .IsRequired();
            Property(t => t.Complemento)
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.FlAtivo)
                .IsRequired();

            // Mappings
            ToTable("Endereco");
            Property(t => t.Logradouro).HasColumnName("Logradouro");
            Property(t => t.CEP).HasColumnName("CEP");
            Property(t => t.Bairro).HasColumnName("Bairro");
            Property(t => t.Cidade).HasColumnName("Cidade");
            Property(t => t.Estado).HasColumnName("Estado");
            Property(t => t.Numero).HasColumnName("Numero");
            Property(t => t.Complemento).HasColumnName("Complemento");
            Property(t => t.FlAtivo).HasColumnName("FlAtivo");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
        }
    }
}
