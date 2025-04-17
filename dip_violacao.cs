//D – Dependency Inversion Principle (DIP)
//A classe de baixo nível (Repositório) depende da abstração (IProdutoRepository), e não de uma implementação concreta.
//Isso permite que a classe de alto nível (ProdutoService) dependa de abstrações, tornando o código mais flexível e testável.
//Além disso, a classe de baixo nível (ProdutoRepository) pode ser substituída por outra implementação que também implemente a interface IProdutoRepository, sem afetar a classe de alto nível (ProdutoService).

//1. Classe depende de classe concreta:
public class Report
{
    private readonly PdfExporter _exporter = new PdfExporter();
}

//2. Serviço com new direto:
public class OrderService
{
    private readonly PaymentService _payment = new PaymentService();
}

//3. Controller usando classe concreta:
public class AuthController
{
    private readonly JwtAuthService _auth = new JwtAuthService();
}

//4. Cliente escolhe estratégia dentro da classe:
public class DiscountApplier
{
    public void Apply(string tipo)
    {
        if (tipo == "blackfriday")
            new BlackFridayDiscount().Apply();
    }
}

//5. Sem injeção de dependência:
public class NotificationService
{
    private readonly EmailSender _sender = new EmailSender();
}