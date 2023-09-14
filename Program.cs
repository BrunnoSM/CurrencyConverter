using System.Globalization;
using ConvertibleCurrencies;

namespace ProgramMain;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Qual é a cotação do dólar? ");
        double dollarRate = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write("Quantos dólares você vai comprar? ");
        double buyingDollar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        CurrencyConverter price = new CurrencyConverter(dollarRate, buyingDollar);

        Console.WriteLine();
        Console.WriteLine(price);
    }
}