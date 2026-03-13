double total = 0;
double nota;
Console.WriteLine("Ingrese la cantidad de alumnos");
int cantAlumnos = int.Parse(Console.ReadLine());
pedirNota(cantAlumnos);
Console.WriteLine($"El resultado del promedio es de: {promClase(cantAlumnos,total)}");




double promClase(double cantAlumnos, double total)
{
    return total / cantAlumnos;
}

void pedirNota(int cantidadAlumnos)
{
    for (int i = 1; i <= cantAlumnos; i++)
    {
        Console.WriteLine($"Ingrese la nota del alumno {i}");
        nota = double.Parse(Console.ReadLine());
        total += nota;
    }
}