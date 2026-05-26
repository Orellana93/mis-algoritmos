//Console.WriteLine("Hello, World!");
// C# — recuerda if(){ } else{ }
Console.WriteLine("Por favor, ingresar nota de 0 a 20:");

string? nota_s = Console.ReadLine();

if (nota_s == null || nota_s.Trim() == "" || !int.TryParse(nota_s, out _))
{
    Console.WriteLine("Entrada no válida. Por favor, ingrese una nota entre 0 y 20.");
    return;
}

int nota = Convert.ToInt32(nota_s);

if (nota >= 0 && nota <= 20)
{
    if (nota >= 11)
    {
        if (nota == 20)
        {
            Console.WriteLine("Excelente");
        }
        else
        {
            Console.WriteLine("Aprobado");
        }
    }
    else
    {
        Console.WriteLine("Desaprobado");
    }
}
else
{
    Console.WriteLine("Nota no válida. Por favor, ingrese una nota entre 0 y 20.");
}
