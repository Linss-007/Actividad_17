Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
saludo(nombre);




void saludo(string nombre)
{
    Console.WriteLine($"Hola {nombre} bienvenido al programa");
}