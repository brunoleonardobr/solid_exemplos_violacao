//D – Dependency Inversion Principle (DIP)
//A classe de baixo nível (Repositório) depende da abstração (IProdutoRepository), e não de uma implementação concreta.
//Isso permite que a classe de alto nível (ProdutoService) dependa de abstrações, tornando o código mais flexível e testável.
//Além disso, a classe de baixo nível (ProdutoRepository) pode ser substituída por outra implementação que também implemente a interface IProdutoRepository, sem afetar a classe de alto nível (ProdutoService).

// Exemplo de violação do DIP:
// Uma classe de alto nível (ProdutoService) depende diretamente de uma classe de baixo nível (ProdutoRepository), o que torna o código rígido e difícil de testar.

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
public class ProdutoRepository
{
    public void Adicionar(Produto produto)
    {
        // Lógica para adicionar o produto ao banco de dados
    }
}
public class ProdutoService
{
    private readonly ProdutoRepository _produtoRepository;

    public ProdutoService()
    {
        _produtoRepository = new ProdutoRepository();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtoRepository.Adicionar(produto);
    }
}
public class ProdutoController
{
    private readonly ProdutoService _produtoService;

    public ProdutoController()
    {
        _produtoService = new ProdutoService();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtoService.AdicionarProduto(produto);
    }
}
// A violação do DIP ocorre quando uma classe de alto nível (ProdutoService) depende diretamente de uma classe de baixo nível (ProdutoRepository), o que torna o código rígido e difícil de testar. Isso pode ser resolvido utilizando injeção de dependência, onde a classe de alto nível depende de uma abstração (interface) em vez de uma implementação concreta.

