using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class EstabelecimentoConfiguration : EntityTypeConfiguration<Estabelecimento>
    {
        public EstabelecimentoConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.CNPJ)
                .HasMaxLength(14)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Estabelecimento_UniqueCNPJ") { IsUnique = true }));
            Property(t => t.NomeFantasia)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.RazaoSocial)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.EnderecoId)
                .IsRequired();
            Property(t => t.TipoEstabelecimentoId)
                .IsRequired();
            Property(t => t.QtdeAparelhos)
                .IsRequired();

            // Mappings
            ToTable("Estabelecimento");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.CNPJ).HasColumnName("CNPJ");
            Property(t => t.NomeFantasia).HasColumnName("NomeFantasia");
            Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            Property(t => t.EnderecoId).HasColumnName("EnderecoId");
            Property(t => t.TipoEstabelecimentoId).HasColumnName("TipoEstabelecimentoId");
            Property(t => t.QtdeAparelhos).HasColumnName("QtdeAparelhos");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
            HasRequired(e => e.Endereco)
                .WithMany(en => en.Estabelecimento)
                .HasForeignKey(e => e.EnderecoId);

            HasRequired(e => e.TipoEstabelecimento)
                .WithMany(te => te.Estabelecimento)
                .HasForeignKey(e => e.EnderecoId);
        }
    }
}
