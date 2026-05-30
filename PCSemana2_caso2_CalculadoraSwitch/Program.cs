Console.WriteLine("Para poder operar 2 números, ingrese el primer número:");

string? nro_1 = Console.ReadLine();

Console.WriteLine("Ingrese el segundo número:");

string? nro_2 = Console.ReadLine();

Console.WriteLine("Ingrese la operación a realizar (suma=1, resta=2, multiplicación=3, división=4):");

string? operacion = Console.ReadLine();

if (nro_1 == null || nro_1.Trim() == "" || !int.TryParse(nro_1, out _))
{
    Console.WriteLine("Entrada no válida para el primer número. Por favor, ingrese un número válido.");
    return;
}

if (nro_2 == null || nro_2.Trim() == "" || !int.TryParse(nro_2, out _))
{
    Console.WriteLine("Entrada no válida para el segundo número. Por favor, ingrese un número válido.");
    return;
}

if (operacion == null || operacion.Trim() == "" || !int.TryParse(operacion, out _))
{
    Console.WriteLine("Entrada no válida para la operación. Por favor, ingrese un número válido.");
    return;
}

int numero1 = Convert.ToInt32(nro_1);
int numero2 = Convert.ToInt32(nro_2);
int operacionNum = Convert.ToInt32(operacion);

switch (operacionNum)
{
    case 1:
        Console.WriteLine($"El resultado de la suma es: {numero1 + numero2}");
        break;
    case 2:
        Console.WriteLine($"El resultado de la resta es: {numero1 - numero2}");
        break;
    case 3:
        Console.WriteLine($"El resultado de la multiplicación es: {numero1 * numero2}");
        break;
    case 4:
        if (numero2 != 0)
        {
            double resultado = (double)numero1 / numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        break;
    default:
        Console.WriteLine("Operación no válida. Por favor, ingrese un número entre 1 y 4.");
        break;
}