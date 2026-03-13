Console.WriteLine("Ingrese el precio de 3 productos");
double pro1 = double.Parse(Console.ReadLine());
double pro2 = double.Parse(Console.ReadLine());
double pro3 = double.Parse(Console.ReadLine());
Console.WriteLine($"El total a pagar por los productos es de: {total(pro1,pro2,pro3)}");



double total(double pro1, double pro2, double pro3)
{
    return pro3 + pro2 + pro1;
}