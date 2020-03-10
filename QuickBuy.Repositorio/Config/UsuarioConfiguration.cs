using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //abordagem CODEFIRST
            builder.HasKey(u => u.id);
            builder
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.nome)
                .IsRequired() //nao quero q exista na tabela de usuario a coluna nome vazio.
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder
                .Property(u => u.senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);

            // builder.Property(u=>u.Pedidos)

            builder // Implementando mapeamento de 1 para muitos.
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);// com o With One tem acesso as propriedades do pedido.E o PEDIDO só pode estar ligado a um USUARIO por vez.

            //Varios pedidos e cada pedido só pode estar relacionado a 1 usuario.





                


        }
    }
}
