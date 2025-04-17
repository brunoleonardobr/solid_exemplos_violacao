//O - Open/Closed Principle (OCP)
// O princípio aberto/fechado afirma que as classes devem ser abertas para extensão, mas fechadas para modificação. Isso significa que você deve ser capaz de adicionar novos comportamentos a uma classe sem alterar seu código existente. Isso pode ser alcançado por meio de herança, interfaces ou composição.
// Isso ajuda a evitar a introdução de bugs em código já testado e facilita a manutenção do sistema.

// Exemplos de violação do OCP:
// Uma classe que precisa ser modificada para adicionar novos comportamentos:

public class ReportGenerator
{
    public string GenerateReport(List<User> users, string reportType)
    {
        if (reportType == "PDF")
        {
            // Lógica para gerar relatório em PDF
            return "Relatório em PDF gerado";
        }
        else if (reportType == "Excel")
        {
            // Lógica para gerar relatório em Excel
            return "Relatório em Excel gerado";
        }
        else
        {
            throw new ArgumentException("Tipo de relatório inválido");
        }
    }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Uma classe que precisa ser modificada para adicionar novos tipos de pagamento:
public class PaymentProcessor
{
    public void ProcessPayment(string paymentType, decimal amount)
    {
        if (paymentType == "CreditCard")
        {
            // Lógica para processar pagamento com cartão de crédito
        }
        else if (paymentType == "PayPal")
        {
            // Lógica para processar pagamento com PayPal
        }
        else
        {
            throw new ArgumentException("Tipo de pagamento inválido");
        }
    }
}