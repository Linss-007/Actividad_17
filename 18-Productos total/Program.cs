double totalPagar = 0;
Console.WriteLine("Ingrese la cantidad de productos");
int cantProducto = int.Parse(Console.ReadLine());
pedirProducto(cantProducto);
Console.WriteLine($"El total a pagar es de: {totalPagar}");





void pedirProducto(int cantProducto)
{
    for (int i = 1; i <= cantProducto; i++)
    {
        Console.WriteLine($"Ingrese el precio del producto {i}");
        double precio = double.Parse(Console.ReadLine());
        totalPagar += precio;
    }
}