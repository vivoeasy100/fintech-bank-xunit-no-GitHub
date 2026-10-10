using FintechBank.App;
using Xunit;

namespace FintechBank.Tests;

public class EmprestimoServiceTests
{
    private readonly EmprestimoService _service;

    public EmprestimoServiceTests()
    {
        _service = new EmprestimoService();
    }

    [Theory]
    [InlineData(10000.00, 10, 800, 1050.00)] // Score alto: 5% de juros -> R$ 10.500 / 10 = R$ 1.050
    [InlineData(10000.00, 10, 600, 1120.00)] // Score médio: 12% de juros -> R$ 11.200 / 10 = R$ 1.120
    [InlineData(10000.00, 10, 400, 1200.00)] // Score baixo: 20% de juros -> R$ 12.000 / 10 = R$ 1.200
    public void CalcularValorParcela_DeveCalcularParcelaComJurosPorScore(decimal valorTotal, int parcelas, int scoreCredito, decimal parcelaEsperada)
    {
        // Act
        decimal parcelaCalculada = _service.CalcularValorParcela(valorTotal, parcelas, scoreCredito);

        // Assert
        Assert.Equal(parcelaEsperada, parcelaCalculada);
    }

    [Theory]
    [InlineData(5000.00, 1500.00, true)]  // Parcela = 30% da renda (5000 * 0.30 = 1500) -> Aprovado
    [InlineData(5000.00, 1600.00, false)] // Parcela > 30% da renda -> Recusado
    public void AprovarEmprestimo_DeveValidarMargemConsignavel(decimal rendaMensal, decimal valorParcela, bool resultadoEsperado)
    {
        // Act
        bool resultado = _service.AprovarEmprestimo(rendaMensal, valorParcela);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
