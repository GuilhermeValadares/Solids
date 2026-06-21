namespace SolidLogistica.SRP;

// SRP: a classe Pedido cuida APENAS dos dados/regras do proprio pedido.
// Persistencia e relatorios foram movidos para classes especificas.
public class Pedido
{
    public int Id { get; set; }
    public decimal Valor { get; set; }

    public Pedido(int id, decimal valor)
    {
        Id = id;
        Valor = valor;
    }
}
