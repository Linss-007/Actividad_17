Console.WriteLine("Ingrese radio del circulo a calcular area");
double radio = double.Parse(Console.ReadLine());
Console.WriteLine($"El area del circulo es de: {areaCirculo(radio)}");


double areaCirculo(double radio)
{
    return 3.1416 * (radio * radio);
}