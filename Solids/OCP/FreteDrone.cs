namespace SolidLogistica.OCP;

// Exemplo de EXTENSAO: um novo tipo de frete sem alterar nenhuma classe existente.
public class FreteDrone : IFrete
{
    public string Tipo => "Drone";
    public decimal Calcular(decimal peso) => peso * 12;
}
