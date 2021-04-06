using ProjetoFidelidade.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFidelidade.Data.Configuration
{
    public class AdminConfiguration : EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            // PK
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Login)
                .HasMaxLength(20)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Admin_UniqueLogin") { IsUnique = true }));
            Property(t => t.Senha)
                .HasMaxLength(20)
                .IsRequired();
            Property(t => t.CPF)
                .HasMaxLength(11)
                .IsRequired();
            Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.DddCelular)
                .HasMaxLength(2)
                .IsRequired();
            Property(t => t.Celular)
                .HasMaxLength(9)
                .IsRequired();
            Property(t => t.DddTelefoneComercial)
                .HasMaxLength(2)
                .IsRequired();
            Property(t => t.TelefoneComercial)
                .HasMaxLength(8)
                .IsRequired();
            Property(t => t.Email)
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.EnderecoId)
                .IsRequired();
            Property(t => t.DataCadastro)
                .IsRequired();

            // Mappings
            ToTable("Admin");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Login).HasColumnName("Login");
            Property(t => t.Senha).HasColumnName("Senha");
            Property(t => t.CPF).HasColumnName("CPF");
            Property(t => t.Nome).HasColumnName("Nome");
            Property(t => t.DddCelular).HasColumnName("DddCelular");
            Property(t => t.Celular).HasColumnName("Celular");
            Property(t => t.DddTelefoneComercial).HasColumnName("DddTelefoneComercial");
            Property(t => t.TelefoneComercial).HasColumnName("TelefoneComercial");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.EnderecoId).HasColumnName("EnderecoId");
            Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");

            // Relationships
            HasRequired(e => e.Endereco)
                .WithMany(en => en.Admin)
                .HasForeignKey(e => e.EnderecoId);

        }
    }
}
