namespace SolidLogistica.SRP;

// Responsabilidade unica: persistencia do pedido.
public class PedidoRepository
{
    public void Salvar(Pedido pedido)
    {
        Console.WriteLine($"Salvando pedido {pedido.Id} no banco...");
    }
}
