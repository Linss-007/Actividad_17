Console.WriteLine("Ingrese los kilogramos a convertir");
double kilog = double.Parse(Console.ReadLine());
Console.WriteLine($"El resultado en libras es de: {kilosgLibra(kilog)}");


double kilosgLibra(double kilog)
{
    return kilog * 2.205;
}