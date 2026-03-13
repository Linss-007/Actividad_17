Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());
descuento(precio);






void descuento(double precio)
{
    Console.WriteLine($"El total con el descuento del 10% es de: {precio / 1.10}");
}