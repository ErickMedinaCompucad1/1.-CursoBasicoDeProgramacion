// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string entrada;
int num;
bool repetir = true;
bool revisar = true;
string op;

while (repetir == true)
{
    //Se repite hasta que sea entero
    Console.WriteLine("Ingrese el numero que desea multiplicar (Solo enteros)");
    do
    {
        entrada = Console.ReadLine();
        if (int.TryParse(entrada, out num))
        {
            revisar = false;
        }
        else {
            Console.WriteLine("Ingrese por favor un numero entero");
        }
    } while (revisar == true);

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} * {num} = {i * num}");
    }

    Console.WriteLine("Desea continuar");
    Console.WriteLine("Si");
    Console.WriteLine("No");
    op = Console.ReadLine();

    switch (op) {
        case "Si":
        case "si":
            repetir = true;
            break;
        case "No":
        case "no":
            repetir = false;
            break;
        default:
            Console.WriteLine("Se tomara como no, adios");
            repetir = false;
            break;
    }
    

}
