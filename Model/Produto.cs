namespace WebApplication1.Model;

public class Produto
{
    public Guid ProdutoId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public string? ImageUrl { get; set; }
    public string? Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
}
