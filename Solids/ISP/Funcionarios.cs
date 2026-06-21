namespace SolidLogistica.ISP;

// ISP: interfaces pequenas e especificas. Cada classe implementa
// somente o que realmente usa.
public interface ITrabalhador
{
    void Trabalhar();
}

public interface IControlePonto
{
    void BaterPonto();
}

public interface IGestor
{
    void GerenciarEquipe();
}

// O desenvolvedor nao e obrigado a implementar GerenciarEquipe.
public class Desenvolvedor : ITrabalhador, IControlePonto
{
    public void Trabalhar() => Console.WriteLine("Programando...");
    public void BaterPonto() => Console.WriteLine("Ponto registrado (desenvolvedor).");
}

// Um gerente combina as capacidades que de fato possui.
public class Gerente : ITrabalhador, IControlePonto, IGestor
{
    public void Trabalhar() => Console.WriteLine("Planejando entregas...");
    public void BaterPonto() => Console.WriteLine("Ponto registrado (gerente).");
    public void GerenciarEquipe() => Console.WriteLine("Gerenciando a equipe.");
}
