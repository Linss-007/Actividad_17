Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());
nacimiento(edad);




void nacimiento(int edad)
{
    Console.WriteLine($"Su año de nacimiento aproximado es de: {2026 - edad}");
}