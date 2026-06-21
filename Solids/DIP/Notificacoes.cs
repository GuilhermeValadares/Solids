namespace SolidLogistica.DIP;

// DIP: PedidoService depende da abstracao INotificacao, nao de implementacoes concretas.
public interface INotificacao
{
    void Enviar(string mensagem);
}

public class EmailService : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"Email enviado: {mensagem}");
}

public class SmsService : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"SMS enviado: {mensagem}");
}

public class WhatsAppService : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"WhatsApp enviado: {mensagem}");
}

public class PushNotificationService : INotificacao
{
    public void Enviar(string mensagem) => Console.WriteLine($"Push enviado: {mensagem}");
}
