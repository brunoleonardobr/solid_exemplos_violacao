//S – Single Responsibility Principle (SRP)

// O princípio da responsabilidade única afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma responsabilidade.
// Isso significa que cada classe deve ser responsável por uma única tarefa ou funcionalidade, o que facilita a manutenção e a compreensão do código.

//1. Classe faz lógica de negócio e persistência:
public class Order
{
    public void AddItem(Item item) { /* lógica */ }
    public void SaveToDatabase() { /* persiste no banco */ }
}

//2. Controller que trata requisição e faz validação manual:
public class OrderController
{
    public void CreateOrder(Order order)
    {
        if (order == null) throw new ArgumentNullException(nameof(order));
        // lógica de criação de pedido
    }
}

//3. Classe que gera relatório e envia e-mail:
public class ReportGenerator
{
    public void GenerateReport(Order order) { /* gera relatório */ }
    public void SendEmail(Order order) { /* envia e-mail */ }
}

//4. ViewModel que manipula dados e acessa banco:
public class OrderViewModel
{
    public void LoadData() { /* carrega dados */ }
    public void SaveData() { /* salva dados */ }
}

//5. Classe de utilitário que faz de tudo:
public class Utility
{
    public void DoSomething() { /* faz algo */ }
    public void DoAnotherThing() { /* faz outra coisa */ }
    public void DoYetAnotherThing() { /* faz mais uma coisa */ }
}