// I – Interface Segregation Principle (ISP)
// Uma classe não deve ser forçada a implementar interfaces que não utiliza. Em vez disso, é melhor criar interfaces menores e mais específicas.
// Isso promove a coesão e a reutilização de código, além de facilitar a manutenção e a evolução do sistema.
// O ISP é um princípio importante para garantir que as classes sejam coesas e que o código seja fácil de entender e manter.

//1. Interface grande demais:
public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work() { }
    public void Eat() => throw new NotImplementedException();
}

//2. Interface única para diferentes ações:
public interface IAnimal
{
    void Eat();
    void Fly();
    void Swim();
}

//3. Interface de cadastro com método de exclusão:
public interface IRegisterService
{
    void Create();
    void Delete();
}

public class AuditService : IRegisterService
{
    public void Create() { }
    public void Delete() => throw new InvalidOperationException();
}

//4. Interface única para múltiplos canais:
public interface IMessageSender
{
    void SendEmail();
    void SendSms();
    void SendPush();
}

//5. Interface com responsabilidades mistas:
public interface IUserOperations
{
    void CreateUser();
    void ResetPassword();
    void DeactivateUser();
}