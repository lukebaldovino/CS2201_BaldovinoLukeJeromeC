// See https://aka.ms/new-console-template for more information
double usdAmount, exchangeRate, convertedAmount;

Console.Write("Enter amount in USD: ");
usdAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter exchange rate From USD to EUR: ");
exchangeRate = Convert.ToDouble(Console.ReadLine());

convertedAmount = usdAmount * exchangeRate;

Console.WriteLine($"Amount in EUR: {convertedAmount:N2}");