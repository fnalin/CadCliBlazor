namespace CadCliBlazor.Domain.Entities;

public class Cliente : EntityBase
{
    public int Id { get; set; }
    
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int Idade { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
    public DateTime? DataAtualizacao { get; set; }
}