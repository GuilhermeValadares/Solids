namespace SolidLogistica.OCP;

public class FreteExpresso : IFrete
{
    public string Tipo => "Expressa";
    public decimal Calcular(decimal peso) => peso * 5;
}
