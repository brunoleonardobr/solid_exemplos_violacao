// I – Interface Segregation Principle (ISP)
// Uma classe não deve ser forçada a implementar interfaces que não utiliza. Em vez disso, é melhor criar interfaces menores e mais específicas.
// Isso promove a coesão e a reutilização de código, além de facilitar a manutenção e a evolução do sistema.
// O ISP é um princípio importante para garantir que as classes sejam coesas e que o código seja fácil de entender e manter.

public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work() { }

    // Violação: robôs não comem, mas são forçados a implementar esse método.
    public void Eat() => throw new NotImplementedException();
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

public interface INotificationSender
{
    void SendEmail(string message);
    void SendSms(string message);
    void SendPush(string message);
}

public class SmsSender : INotificationSender
{
    public void SendSms(string message) { }

    // Violação: forçado a implementar métodos que não fazem parte do seu escopo
    public void SendEmail(string message) => throw new NotImplementedException();
    public void SendPush(string message) => throw new NotImplementedException();
}