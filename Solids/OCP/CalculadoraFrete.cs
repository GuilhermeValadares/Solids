namespace SolidLogistica.OCP;

// Agora a calculadora apenas delega para a abstracao IFrete.
// Nao precisa de if/else e nunca muda quando surge um novo tipo de frete.
public class CalculadoraFrete
{
    public decimal Calcular(IFrete frete, decimal peso) => frete.Calcular(peso);
}
