Console.WriteLine("Ingrese la base del reactangulo");
double baseRec = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRec = double.Parse(Console.ReadLine());
Console.WriteLine($"El area del rectangulo es de: {areaRec(alturaRec, baseRec)}");


double areaRec(double baseRec, double alturaRec)
{
    return baseRec * alturaRec;
}