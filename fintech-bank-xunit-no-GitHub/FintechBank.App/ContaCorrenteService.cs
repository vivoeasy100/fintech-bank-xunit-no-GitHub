namespace FintechBank.App;

public class ContaCorrenteService
{
    /// <summary>
    /// Calcula a taxa de manutenção mensal da conta corrente com base no saldo e status do cliente.
    /// - Saldo >= R$ 5.000,00 OU clienteEspecial == true: Isento (0.00m).
    /// - Saldo entre R$ 1.000,00 e R$ 4.999,99 (e não especial): R$ 12.50m.
    /// - Saldo menor que R$ 1.000,00 (e não especial): R$ 25.00m.
    /// </summary>
    public decimal CalcularTaxaManutencao(decimal saldo, bool clienteEspecial)
    {
        if (clienteEspecial || saldo >= 5000.00m)
        {
            return 0.00m;
        }

        if (saldo >= 1000.00m && saldo <= 4999.99m)
        {
            return 12.50m;
        }

        return 25.00m;
    }

    /// <summary>
    /// Verifica se o cliente pode realizar um saque com base no saldo e limite de cheque especial disponível.
    /// - Retorna true se valorSaque <= (saldo + limiteChequeEspecial).
    /// </summary>
    public bool PodeRealizarSaque(decimal saldo, decimal limiteChequeEspecial, decimal valorSaque)
    {
        return valorSaque <= (saldo + limiteChequeEspecial);
    }
}
