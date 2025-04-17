//L – Liskov Substitution Principle (LSP)
// As classes derivadas devem ser substituíveis por suas classes base sem alterar o comportamento do programa.
// Ou seja, se uma classe A é uma subclasse de B, então deve ser possível substituir B por A sem que o programa falhe ou apresente comportamentos inesperados.
// Isso significa que as subclasses devem manter a mesma interface e comportamento da classe base, respeitando o contrato estabelecido por ela.
// Isso garante que o código que utiliza a classe base funcione corretamente com as subclasses, promovendo a reutilização e a extensibilidade do código.

//1. Subclasse que lança exceção:
public class Bird { public virtual void Fly() {} }

public class Ostrich : Bird
{
    public override void Fly() => throw new NotImplementedException();
}

//2. Subclasse altera comportamento esperado:
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
}

public class Square : Rectangle
{
    public override int Width { set { base.Width = value; base.Height = value; } }
    public override int Height { set { base.Width = value; base.Height = value; } }
}

//3. Classe filha ignora contrato da base:
public class FileExporter
{
    public virtual void Export() => Console.WriteLine("Exportando...");
}

public class SilentExporter : FileExporter
{
    public override void Export() { }
}

//4. Animal que fala mas nem todos falam:
public class Animal
{
    public virtual void Speak() => Console.WriteLine("Sound");
}

public class Fish : Animal
{
    public override void Speak() => throw new Exception("Fish can't speak!");
}

//5. Subclasse muda retorno:
public class Payment
{
    public virtual bool Process() => true;
}

public class InvalidPayment : Payment
{
    public override bool Process() => throw new Exception("Invalid");
}