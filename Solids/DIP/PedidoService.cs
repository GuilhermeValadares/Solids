namespace SolidLogistica.DIP;

// A dependencia e injetada via construtor (injecao de dependencia).
// Trocar de Email para SMS/WhatsApp/Push nao altera esta classe.
public class PedidoService
{
    private readonly INotificacao _notificacao;

    public PedidoService(INotificacao notificacao)
    {
        _notificacao = notificacao;
    }

    public void FinalizarPedido()
    {
        Console.WriteLine("Pedido finalizado.");
        _notificacao.Enviar("Pedido concluido.");
    }
}
