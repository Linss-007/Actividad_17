Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la calificacion 1");
double calif1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificacion 2");
double calif2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la calificacion 3");
double calif3 = double.Parse(Console.ReadLine());
Console.WriteLine($"hola {nombre} el promedio de las calificaciones es de: {promCalif(calif1,calif2,calif3)}");




double promCalif(double calif1, double calif2, double calif3)
{
    return (calif1 + calif2 + calif3) / 3;
}