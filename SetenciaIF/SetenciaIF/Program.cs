// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int edad;
string mensaje = "";
bool continuar = true;



do
{
    Console.WriteLine("Ingresa tu edad");
    edad = Convert.ToInt32(Console.ReadLine());
    if (edad >= 18)
    {
        mensaje = "Puedes tomar eres mayor de edad";
        if (edad == 25) {
            Console.WriteLine("Aun eres muy joven");
        }
    }
    else if (edad <= 17 && edad >= 11)
    {
        mensaje = "Eres un adolesente no puedes tomar";
    }
    else if (edad <= 10 && edad >= 1)
    {
        mensaje = "Vete de aqui niño";
    }

    Console.WriteLine(mensaje);
    Console.WriteLine("Deseas repetir");
    Console.WriteLine("Si");
    Console.WriteLine("No");
    string op = Console.ReadLine();
    if (op == "Si" || op == "si")
    {
        continuar = true;
    }
    else {
        continuar = false;
    }

} while (continuar == true);