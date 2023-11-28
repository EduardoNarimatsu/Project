public static class CalculaCDB
{
    public static ResponseModel Calcular(double valorInicial, int prazoMes)
    {
        double tb = 1.08;
        double cdi = 0.009;
        double valorFinal = valorInicial;
        double valorLiquido = 0;

        for (int i = 0; i < prazoMes; i++)
        {
            valorFinal *= (1 + (cdi * tb));
        }

        double taxaImposto = 0;

        if (prazoMes <= 6)
        {
            taxaImposto = 0.225;
        }
        else if (prazoMes <= 12)
        {
            taxaImposto = 0.2;
        }
        else if (prazoMes <= 24)
        {
            taxaImposto = 0.175;
        }
        else
        {
            taxaImposto = 0.15;
        }

        valorLiquido = valorFinal - (valorFinal - valorInicial) * taxaImposto;

        return new ResponseModel
        {
            ValorFinal = valorFinal,
            ValorLiquido = valorLiquido
        };
    }
}