
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using TutorialEcommerce.Domain.Entities;

namespace TutorialEcommerce.Reposotories.EntityTypesConfigurations
{
    public class UsuarioConfigurations : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfigurations()
        {
            Property(x => x.Cpf.Codigo)
                .HasColumnName("Cpf")
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAttribute("IX_CPF", 1) { IsUnique = true });

            Property(x => x.Login)
                .HasMaxLength(Usuario.LoginMaxValue)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("IX_Login", 2) { IsUnique = true }));
        }
    }
}
