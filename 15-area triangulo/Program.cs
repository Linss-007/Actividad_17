Console.WriteLine("Ingrese la base del triangulo");
double baseTri = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
double alturaTri = double.Parse(Console.ReadLine());
Console.WriteLine($"El area del triangulo es de: {areaTri(baseTri, alturaTri)}");


double areaTri(double baseTri, double alturaTri)
{
    double area = 0.5 * (baseTri * alturaTri);
    return area;
}