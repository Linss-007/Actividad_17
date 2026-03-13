Console.WriteLine("Ingrese el primer numero a sumar");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero a sumar");
double num2 = double.Parse(Console.ReadLine());
suma(num1, num2);




void suma(double num1, double num2)
{
    Console.WriteLine($"El resultado de la suma es de: {num1 + num2}");
}