// Conversor Celsius → Fahrenheit
//Ler uma temperatura em °C e mostrar em °F. Fórmula: F = (C × 9 / 5) +32

double celsius, fahrenheit;

Console.Write("Digite a temperatura em °C: ");
celsius = Convert.ToDouble(Console.ReadLine());
fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"A temperatura em °F é: {fahrenheit}");


