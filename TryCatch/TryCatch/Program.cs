// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int num;
while (true)
{
    Console.WriteLine("Ingrese un numero entero");
    try {
        //Intenta convertir
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Numero valido = {num}");

        //Sale del while
        break;
    }
    catch (FormatException)
    {
        // Si el usuario escribe "hola", "3.5", etc.
        Console.WriteLine("Formato inválido. Por favor ingrese solo números enteros.");
        continue; // Volver a pedir el número
    }
    catch (OverflowException)
    {
        // Si el número es muy grande para ser int
        Console.WriteLine("El número es demasiado grande. Intente con un valor más pequeño.");
        continue;
    }
    catch (Exception ex)
    {
        // Cualquier otra excepción inesperada
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        continue;
    }

}

Console.WriteLine("Se termino el ciclo");
Console.ReadKey();