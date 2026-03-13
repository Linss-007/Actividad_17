Console.WriteLine("Ingrese la distancia recorrida");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo tardado");
double tiempo = double.Parse(Console.ReadLine());
Console.WriteLine($"La rapidez es de: {velocidad(distancia,tiempo)}");


double velocidad(double distacia, double tiempo)
{
    return distacia / tiempo;
}