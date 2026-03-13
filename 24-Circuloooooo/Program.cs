Console.WriteLine("Ingrese el radio del circulo");
double radio = double.Parse(Console.ReadLine());
area(radio);




void area(double radio)
{
    Console.WriteLine($"El area del circulo es de: {3.1416 * (radio * radio)}");
}