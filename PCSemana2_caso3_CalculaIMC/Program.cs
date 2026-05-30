Console.WriteLine("Para obtener el IMC, ingrese su peso en kg:");

string? peso = Console.ReadLine();

Console.WriteLine("Ingrese su altura en metros:");

string? altura = Console.ReadLine();

if (peso == null || peso.Trim() == "" || !double.TryParse(peso, out _))
{
    Console.WriteLine("Entrada no válida para el peso. Por favor, ingrese un número válido.");
    return;
}

if (altura == null || altura.Trim() == "" || !double.TryParse(altura, out _))
{
    Console.WriteLine("Entrada no válida para la altura. Por favor, ingrese un número válido.");
    return;
}

double pesoNum = Convert.ToDouble(peso);
double alturaNum = Convert.ToDouble(altura);
double imc = pesoNum / (alturaNum * alturaNum);

Console.WriteLine($"Su IMC es: {imc:F2}");

if (imc < 18.5)
{
    Console.WriteLine("Usted se encuentra bajo de peso.");
}
else if (imc < 25)
{
    Console.WriteLine("Usted se encuentra con un peso normal.");
}
else if (imc < 30)
{
    Console.WriteLine("Usted se encuentra con Sobrepeso.");
}
else
{
    Console.WriteLine("Usted se encuentra con Obesidad.");
}
