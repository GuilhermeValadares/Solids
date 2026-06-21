namespace SolidLogistica.OCP;

public class FreteNormal : IFrete
{
    public string Tipo => "Normal";
    public decimal Calcular(decimal peso) => peso * 2;
}
