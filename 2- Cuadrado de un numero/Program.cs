Console.WriteLine("Ingrese numero a sacar cuadrado");
double numero = double.Parse(Console.ReadLine());
Console.WriteLine("El resultado del cuadrado es de: " + cuadrado(numero));



double cuadrado(double numero)
{
    return numero * numero;
}