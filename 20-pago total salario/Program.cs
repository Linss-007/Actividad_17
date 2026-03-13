Console.WriteLine("Ingrese cantidad de dias trabajados");
int dias = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el pago por dia");
double pagoDia = double.Parse(Console.ReadLine());
Console.WriteLine($"Su salario total es de: {salario(dias,pagoDia)}");



double salario(double dias, double pagoDia)
{
    return dias * pagoDia;
}