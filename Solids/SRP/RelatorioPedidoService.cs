namespace SolidLogistica.SRP;

// Responsabilidade unica: geracao de relatorios do pedido.
public class RelatorioPedidoService
{
    public void Gerar(Pedido pedido)
    {
        Console.WriteLine($"Gerando relatorio do pedido {pedido.Id} (valor: {pedido.Valor:C})...");
    }
}
