using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.CPF)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Cliente_UniqueCPF") { IsUnique = true }));
            Property(t => t.Email)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Cliente_UniqueEmail") { IsUnique = true }));
            Property(t => t.DddCelular)
                .HasMaxLength(2)
                .IsRequired();
            Property(t => t.Celular)
                .HasMaxLength(9)
                .IsRequired();

            // Mappings
            ToTable("Cliente");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Nome).HasColumnName("Nome");
            Property(t => t.CPF).HasColumnName("CPF");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.DddCelular).HasColumnName("DddCelular");
            Property(t => t.Celular).HasColumnName("Celular");
            Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
        }
    }
}
