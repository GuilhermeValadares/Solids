using SolidLogistica.SRP;
using SolidLogistica.OCP;
using SolidLogistica.LSP;
using SolidLogistica.ISP;
using SolidLogistica.DIP;

Console.WriteLine("=== Parte A - SRP (Single Responsibility Principle) ===");
var pedido = new Pedido(1, 250.00m);
var pedidoRepository = new PedidoRepository();
var relatorioService = new RelatorioPedidoService();
pedidoRepository.Salvar(pedido);
relatorioService.Gerar(pedido);

Console.WriteLine();
Console.WriteLine("=== Parte B - OCP (Open/Closed Principle) ===");
var calculadora = new CalculadoraFrete();
var fretes = new List<IFrete>
{
    new FreteNormal(),
    new FreteExpresso(),
    new FretePremium(),
    new FreteDrone() // novo tipo adicionado sem alterar codigo existente
};
decimal peso = 10m;
foreach (var frete in fretes)
{
    Console.WriteLine($"Frete {frete.Tipo} ({peso} kg): {calculadora.Calcular(frete, peso):C}");
}

Console.WriteLine();
Console.WriteLine("=== Parte C - LSP (Liskov Substitution Principle) ===");
var veiculos = new List<Veiculo> { new Carro(), new CarroEletrico() };
foreach (var veiculo in veiculos)
{
    veiculo.Mover(); // todos podem mover, sem quebrar nada
    if (veiculo is IAbastecivel abastecivel) abastecivel.Abastecer();
    if (veiculo is IRecarregavel recarregavel) recarregavel.Recarregar();
}

Console.WriteLine();
Console.WriteLine("=== Parte D - ISP (Interface Segregation Principle) ===");
var desenvolvedor = new Desenvolvedor();
desenvolvedor.Trabalhar();
desenvolvedor.BaterPonto();

var gerente = new Gerente();
gerente.Trabalhar();
gerente.BaterPonto();
gerente.GerenciarEquipe();

Console.WriteLine();
Console.WriteLine("=== Parte E - DIP (Dependency Inversion Principle) ===");
var canais = new List<INotificacao>
{
    new EmailService(),
    new SmsService(),
    new WhatsAppService(),
    new PushNotificationService()
};
foreach (var canal in canais)
{
    var pedidoService = new PedidoService(canal);
    pedidoService.FinalizarPedido();
}
