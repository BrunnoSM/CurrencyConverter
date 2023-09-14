using System.Globalization;

namespace ConvertibleCurrencies;

class CurrencyConverter
{

    public double DollarExchangeRate { get; set; }
    public double DollarPurchase { get; set; }

    // Método Construtor
    public CurrencyConverter(double dollarExchangeRate, double dollarPurchase)
    {
        DollarExchangeRate = dollarExchangeRate;
        DollarPurchase = dollarPurchase;
    }

    public double CalculatesTax()
    {
        double iof = 6.0;
        double tax = (DollarPurchase * iof) / 100;
        return (DollarPurchase + tax) * DollarExchangeRate;
    }

    public override string ToString()
    {
        return $"Valor a ser pago em reais = {CalculatesTax().ToString("F2", CultureInfo.InvariantCulture)}";
    }

}

