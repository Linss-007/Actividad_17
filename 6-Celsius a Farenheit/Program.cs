Console.WriteLine("Ingrese los grados Celsius");
double celsius = double.Parse(Console.ReadLine());
Console.WriteLine($"El resultado en Farenheit es de: {celFarenheit(celsius)}");

double celFarenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}