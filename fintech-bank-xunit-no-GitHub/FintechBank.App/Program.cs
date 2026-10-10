using FintechBank.App;

Console.WriteLine("==================================================");
Console.WriteLine("           FINTECHBANK - SISTEMA BANCÁRIO         ");
Console.WriteLine("==================================================");

var contaService = new ContaCorrenteService();
var emprestimoService = new EmprestimoService();

Console.WriteLine("\n[Simulação 1] Taxa de Manutenção:");
decimal taxa1 = contaService.CalcularTaxaManutencao(6000.00m, false);
Console.WriteLine($"Saldo: R$ 6.000,00 | Especial: Não => Taxa: R$ {taxa1:F2} (Isento)");

decimal taxa2 = contaService.CalcularTaxaManutencao(2500.00m, false);
Console.WriteLine($"Saldo: R$ 2.500,00 | Especial: Não => Taxa: R$ {taxa2:F2}");

Console.WriteLine("\n[Simulação 2] Validação de Saque:");
bool saque1 = contaService.PodeRealizarSaque(1000.00m, 500.00m, 1200.00m);
Console.WriteLine($"Saldo: R$ 1000 | Limite: R$ 500 | Saque: R$ 1200 => Permitido: {saque1}");

bool saque2 = contaService.PodeRealizarSaque(1000.00m, 500.00m, 1600.00m);
Console.WriteLine($"Saldo: R$ 1000 | Limite: R$ 500 | Saque: R$ 1600 => Permitido: {saque2}");

Console.WriteLine("\n[Simulação 3] Empréstimo e Parcelas:");
decimal parcela = emprestimoService.CalcularValorParcela(10000.00m, 10, 800);
Console.WriteLine($"Empréstimo R$ 10.000 em 10x (Score 800) => Parcela: R$ {parcela:F2}");

bool aprovado = emprestimoService.AprovarEmprestimo(5000.00m, parcela);
Console.WriteLine($"Renda R$ 5.000,00 para parcela de R$ {parcela:F2} => Aprovado: {aprovado}");

Console.WriteLine("\nPara rodar a suíte completa de testes parametrizados, execute:");
Console.WriteLine("  dotnet test\n");
