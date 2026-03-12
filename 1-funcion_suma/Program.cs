Console.WriteLine("Ingrese el primer numero");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("El resultado de la suma es de: " + suma(num1,num2));




double suma(double num1, double num2)
{
    return num1 + num2;
}