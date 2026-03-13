Console.WriteLine("Ingrese el primer numero");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine($"El resultado del promedio de los numeros es de: {promedio(num1,num2,num3)}");



double promedio(double num1, double num2, double num3)
{
    return (num1 + num2 + num3) / 3;
}