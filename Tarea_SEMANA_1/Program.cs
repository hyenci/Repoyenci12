
//lista de nombres ordenados alfabeticamente
static void listnom()
{
    Console.WriteLine("Ingresa los nombres separados por comas:");
    string noms = Console.ReadLine();

    string[] nombres = noms.Split(',');

    Array.Sort(nombres);

    Console.WriteLine("Lista de nombres ordenada:");
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre.Trim());
    }
}

//valor maximo y minimo de la lista de valores

static void lisnum()
{
    Console.WriteLine("Ingresa una lista de números enteros separados por espacios:");
    string input = Console.ReadLine();

    int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

    int maxValue = numbers.Max();
    int minValue = numbers.Min();

    Console.WriteLine($"El valor máximo de la lista es: {maxValue}");
    Console.WriteLine($"El valor mínimo de la lista es: {minValue}");
}

//Ejercicio 3 paises

static void pais()
{
    string[] paises = { "Estados Unidos", "Canadá", "México", "Brasil", "Argentina" };

    Console.WriteLine("Ingresa un nombre de país:");
    string paisBuscado = Console.ReadLine();

    int indice = Array.IndexOf(paises, paisBuscado);

    if (indice != -1)
    {
        Console.WriteLine("El país '" + paisBuscado + "' fue encontrado en la posición " + indice + " del arreglo.");
    }
    else
    {
        Console.WriteLine("El país '" + paisBuscado + "' no fue encontrado en el arreglo.");
    }
}

//Ejercicio 4

static void are()
{
    int[] numeros = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Arreglo original:");
    ImprimirArreglo(numeros);

    Array.Reverse(numeros);

    Console.WriteLine("\nArreglo invertido:");
    ImprimirArreglo(numeros);
}

static void ImprimirArreglo(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
}

//ejercicio 5

static void ejer5(string[] args)
{
    Console.WriteLine("Ingrese las calificaciones separadas por comas:");
    string cali = Console.ReadLine();

    string[] calificacionesStr = cali.Split(',');
    int[] calificaciones = new int[calificacionesStr.Length];
    for (int i = 0; i < calificacionesStr.Length; i++)
    {
        calificaciones[i] = int.Parse(calificacionesStr[i]);
    }


    bool haySobresalientes = false;
    foreach (int calificacion in calificaciones)
    {
        if (calificacion >= 90)
        {
            haySobresalientes = true;
            break;
        }
    }

    if (haySobresalientes)
    {
        Console.WriteLine("¡Hay calificaciones sobresalientes!");
    }
    else
    {
        Console.WriteLine("No hay calificaciones sobresalientes.");
    }
}

Console.WriteLine("");