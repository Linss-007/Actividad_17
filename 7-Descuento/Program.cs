Console.WriteLine("Ingrese precio del producto");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de descuento del producto");
double descuento = double.Parse(Console.ReadLine());
Console.WriteLine($"El total con el descuento aplicado es de: {totalDesc(precio,descuento)}");



double totalDesc(double precio, double descuento)
{
    return precio - (precio * (descuento / 100));
}