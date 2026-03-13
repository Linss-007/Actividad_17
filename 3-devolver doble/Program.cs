Console.WriteLine("Ingrese numero a sacar doble");
double numero = double.Parse(Console.ReadLine());
Console.WriteLine($"El resultado del doble es de: {doble(numero)}");


double doble(double numero)
{
    return numero * 2;
}