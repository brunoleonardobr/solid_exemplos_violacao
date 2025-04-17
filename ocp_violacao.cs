//O - Open/Closed Principle (OCP)
// O princípio aberto/fechado afirma que as classes devem ser abertas para extensão, mas fechadas para modificação. Isso significa que você deve ser capaz de adicionar novos comportamentos a uma classe sem alterar seu código existente. Isso pode ser alcançado por meio de herança, interfaces ou composição.
// Isso ajuda a evitar a introdução de bugs em código já testado e facilita a manutenção do sistema.

//1. Switch para tipos de desconto:
public class DiscountService
{
    public double ApplyDiscount(string type)
    {
        switch (type)
        {
            case "gold": return 0.1;
            case "silver": return 0.05;
            default: return 0;
        }
    }
}

//2. Classe de relatório que muda para novos formatos:
public class Report
{
    public void Export(string type)
    {
        if (type == "pdf") { /* gera PDF */ }
        else if (type == "excel") { /* gera Excel */ }
    }
}

//3. Estratégia fixa para cálculo de frete:
public class ShippingCalculator
{
    public double CalculateShipping(string type)
    {
        if (type == "standard") return 10.0;
        else if (type == "express") return 20.0;
        else return 0.0;
    }
}

//4. Botões com comportamento embutido:
public class Button
{
    public void Click(string action)
    {
        if (action == "save") { /* salva */ }
        else if (action == "delete") { /* deleta */ }
    }
}

//5. Logger com tratamento específico por tipo:
public class Logger
{
    public void Log(string type, string message)
    {
        if (type == "info") { /* loga info */ }
        else if (type == "error") { /* loga erro */ }
    }
}