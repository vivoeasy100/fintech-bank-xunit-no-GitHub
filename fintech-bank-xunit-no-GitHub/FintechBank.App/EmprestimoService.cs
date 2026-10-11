namespace FintechBank.App;

// Serviço responsável pelo cálculo das parcelas e aprovação de empréstimos.
public class EmprestimoService
{
    /// <summary>
    /// Calcula o valor da parcela individual de um empréstimo de acordo com o score de crédito:
    /// - Score >= 700: 5% de juros totais (valorTotal * 1.05m).
    /// - Score entre 500 e 699: 12% de juros totais (valorTotal * 1.12m).
    /// - Score < 500: 20% de juros totais (valorTotal * 1.20m).
    /// Retorna: valorComJuros / parcelas.
    /// </summary>
    public decimal CalcularValorParcela(decimal valorTotal, int parcelas, int scoreCredito)
    {
        if (parcelas <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(parcelas), "A quantidade de parcelas deve ser maior que zero.");
        }

        decimal fatorJuros;
        if (scoreCredito >= 700)
        {
            fatorJuros = 1.05m;
        }
        else if (scoreCredito >= 500)
        {
            fatorJuros = 1.12m;
        }
        else
        {
            fatorJuros = 1.20m;
        }

        decimal valorComJuros = valorTotal * fatorJuros;
        return valorComJuros / parcelas;
    }

    /// <summary>
    /// Avalia a aprovação de um empréstimo por margem consignável.
    /// - Aprovado (true) apenas se valorParcela <= rendaMensal * 0.30m (máximo 30% da renda).
    /// </summary>
    public bool AprovarEmprestimo(decimal rendaMensal, decimal valorParcela)
    {
        return valorParcela <= (rendaMensal * 0.30m);
    }
}
