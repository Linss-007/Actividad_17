Console.WriteLine("Ingrese los minutos");
int minutos = int.Parse(Console.ReadLine());
Console.WriteLine($"El resultado de los minutos a horas es de: {minHora(minutos)}");


double minHora(double minutos)
{
    return minutos/60;
}