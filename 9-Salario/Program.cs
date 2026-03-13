Console.WriteLine("Ingrese las horas trabajadas");
double horas = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el pago por hora");
double pagoHora = double.Parse(Console.ReadLine());
Console.WriteLine($"El total del pago es de: {salario(horas,pagoHora)}");

double salario(double horas, double pagoHora)
{
    return horas * pagoHora;
}