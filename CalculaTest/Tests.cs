using TestApi;

namespace CalculaTest;

public class Tests
{
    private readonly CalculaService _calculaService;

    public Tests()
    {
        _calculaService = new CalculaService();
    }

    [Fact]
    public void CalcularInvestimento_RetornaValorCorreto_QuandoDadosValidos()
    {
        // Arrange
        double valorInicial = 1200;
        int prazoMeses = 12;
        double resultFinal = 2155.027591226556;

        // Act
        double resultado = _calculaService.CalculaCDB(valorInicial, prazoMeses);

        // Assert
        Assert.Equal(resultFinal, resultado, 2);
    }
}
