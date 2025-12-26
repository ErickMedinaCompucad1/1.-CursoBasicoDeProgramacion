// See https://aka.ms/new-console-template for more information

int operation, fistData, secondData;
bool repetir = true;
string userResponse;

while (repetir == true)
{
    Saludo();
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    operation = GetIntegerDataFromUSer("Proporciona la operacion que deseas ejecutar");//Este es el mensaje

    switch (operation)
    {
        case 1:
            fistData = GetIntegerDataFromUSer("Proporciona el primer valor para sumar");
            secondData = GetIntegerDataFromUSer("Proporciona el segundo valor para sumar");
            Console.WriteLine($"El resultado de la suma es: {Suma(fistData, secondData)}");
            break;
        case 2:
            fistData = GetIntegerDataFromUSer("Proporciona el primer valor para restar");
            secondData = GetIntegerDataFromUSer("Proporciona el segundo valor para restar");
            Console.WriteLine($"El resultado de la resta es: {Resta(fistData, secondData)}");
            break;
        default:
            Console.WriteLine("La operacion proporcionada no es valida");
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? (s/n)");
    userResponse= Console.ReadLine();
    if(userResponse.ToLower() == "s")
    {
        repetir = true;
    }else
    {
        repetir = false;
    }
}

//Esta funcion valida que el usuario proporcione un entero valido
static int GetIntegerDataFromUSer(string menssage)
{
    string userValue;
    int data = 0;
    bool isDataValid = false;

    while (!isDataValid) 
    {
        //Manda el mensaje
        Console.WriteLine(menssage);
        userValue = Console.ReadLine();
        if (!int.TryParse(userValue, out data))
        {
            //Si no lo puede convertir
            Console.WriteLine("El valor proporcionado no es un entero valido");
            isDataValid = false;
        }
        else 
        {
            //Si lo puede convertir
            isDataValid = true;
        }
    }
    return data;
}


static int Suma(int a, int b) 
{ 
    return a + b;
}

static int Resta(int a, int b)
{
    return a - b;
}

//Void se coloca cuando no se espera ningun valor de retorno
static void Saludo()
{
     Console.WriteLine("Hola, bienvenido a la programacion en C#");
}