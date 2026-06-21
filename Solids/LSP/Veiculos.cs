namespace SolidLogistica.LSP;

// LSP: a superclasse Veiculo NAO obriga todo veiculo a abastecer.
// Apenas veiculos com combustivel implementam a capacidade de abastecer.
public abstract class Veiculo
{
    public abstract void Mover();
}

// Capacidade especifica: apenas quem realmente abastece implementa.
public interface IAbastecivel
{
    void Abastecer();
}

// Capacidade especifica: apenas quem carrega bateria implementa.
public interface IRecarregavel
{
    void Recarregar();
}

public class Carro : Veiculo, IAbastecivel
{
    public override void Mover() => Console.WriteLine("Carro em movimento.");
    public void Abastecer() => Console.WriteLine("Abastecendo carro com combustivel.");
}

public class CarroEletrico : Veiculo, IRecarregavel
{
    public override void Mover() => Console.WriteLine("Carro eletrico em movimento.");
    public void Recarregar() => Console.WriteLine("Recarregando bateria do carro eletrico.");
}
