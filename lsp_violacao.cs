//L – Liskov Substitution Principle (LSP)
// As classes derivadas devem ser substituíveis por suas classes base sem alterar o comportamento do programa.
// Ou seja, se uma classe A é uma subclasse de B, então deve ser possível substituir B por A sem que o programa falhe ou apresente comportamentos inesperados.
// Isso significa que as subclasses devem manter a mesma interface e comportamento da classe base, respeitando o contrato estabelecido por ela.
// Isso garante que o código que utiliza a classe base funcione corretamente com as subclasses, promovendo a reutilização e a extensibilidade do código.

// Exemplo de violação do LSP:
// Uma classe `Cachorro` que herda de uma classe `Animal` e altera o comportamento esperado da classe base.

public class Animal
{
    public virtual void FazerBarulho()
    {
        Console.WriteLine("Animal faz barulho");
    }
}
public class Cachorro : Animal
{
    public override void FazerBarulho()
    {
        Console.WriteLine("Cachorro late");
    }
}
public class Peixe : Animal
{
    public override void FazerBarulho()
    {
        Console.WriteLine("Peixe não faz barulho");
    }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Outro exemplo de violação do LSP via interface:
// Uma interface `Forma` que define um método `CalcularArea`, mas a implementação de uma classe `Circulo` não respeita o contrato da interface.
public interface IForma
{
    double CalcularArea();
}
public class Circulo : IForma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
public class Retangulo : IForma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
}
public class AreaCalculator
{
    public double CalcularArea(IForma forma)
    {
        return forma.CalcularArea();
    }
}
// A violação do LSP ocorre quando a implementação de `CalcularArea` em `Circulo` não respeita o contrato da interface `IForma`, pois o método não é aplicável a todas as formas. Isso pode levar a comportamentos inesperados quando se tenta calcular a área de um círculo usando a interface `IForma`.
