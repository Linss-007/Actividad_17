Console.WriteLine("Ingrese la base del rectangulo");
double baseRec = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura rectangulo");
double alturaRec = double.Parse(Console.ReadLine());
areaRec(baseRec, alturaRec);



void areaRec(double baseRec, double alturaRec)
{
    Console.WriteLine($"El resultado del area es de: {baseRec * alturaRec}");
}