using CadCliBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadCliBlazor.Data.Config;

public class ClienteConfig : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).HasColumnType("varchar(255)").IsRequired();
        builder.Property(x => x.Email).HasColumnType("varchar(100)").IsRequired();
        builder.Property(x => x.Idade).HasColumnType("tinyint").IsRequired();
        builder.Property(x => x.DataCadastro).HasColumnType("datetime2").IsRequired();
        builder.Property(x => x.DataAtualizacao).HasColumnType("datetime2");

        builder.HasData([
            new() {Id = 1, Nome = "Fabiano", Email = "fabiano.nalin@gmail.com", Idade = 45},
            new() {Id = 2, Nome = "Lucas", Email = "lucas@teste.com", Idade = 25}
        ]);
    }
}