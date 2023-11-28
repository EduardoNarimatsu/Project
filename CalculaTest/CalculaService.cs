using System;
namespace TestApi
{
	public class CalculaService
	{
        public double CalculaCDB(double valorInicial, int prazoMes)
        {
            double taxaJuros = 0.05;

            double valorFinal = valorInicial * Math.Pow(1 + taxaJuros, prazoMes);

            return valorFinal;
        }
    }
}

