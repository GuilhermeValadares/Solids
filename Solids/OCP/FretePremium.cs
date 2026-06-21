namespace SolidLogistica.OCP;

public class FretePremium : IFrete
{
    public string Tipo => "Premium";
    public decimal Calcular(decimal peso) => peso * 8;
}
