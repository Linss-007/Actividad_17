Console.WriteLine("Ingrese numero");
double numero = double.Parse(Console.ReadLine());
Console.WriteLine($"El cubo del numero es de: {cubo(numero)}");


double cubo(double numero)
{
    return (numero * numero) * numero;
}