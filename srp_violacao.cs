//S – Single Responsibility Principle (SRP)

// O princípio da responsabilidade única afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma responsabilidade.
// Isso significa que cada classe deve ser responsável por uma única tarefa ou funcionalidade, o que facilita a manutenção e a compreensão do código.

// Exemplos de violação do SRP:
// Uma classe que lida com a lógica de negócios e também com a persistência de dados:

public class UserService
{
    public void RegisterUser(User user)
    {
        // Lógica de registro de usuário
        SaveToDatabase(user);
    }

    private void SaveToDatabase(User user)
    {
        // Lógica de persistência de dados
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Uma classe que lida com a lógica de negócios e também com a formatação de dados para exibição:

public class ReportGenerator
{
    public string GenerateReport(List<User> users)
    {
        // Lógica de geração de relatório
        return FormatReport(users);
    }

    private string FormatReport(List<User> users)
    {
        // Lógica de formatação de relatório
        return "Relatório formatado";
    }
}