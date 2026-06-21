namespace SolidLogistica.OCP;

// OCP: aberto para extensao (novos tipos de frete), fechado para modificacao.
// Para um novo tipo basta criar uma nova classe que implemente IFrete.
public interface IFrete
{
    string Tipo { get; }
    decimal Calcular(decimal peso);
}
