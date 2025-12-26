// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int op;
string op2;
bool repetir = true;



do {
    Console.WriteLine("Que refresco quieres?");
    Console.WriteLine("1.- Coca");
    Console.WriteLine("2.- Manzanita");
    Console.WriteLine("3.- RedBull");
    Console.WriteLine("4.- Jarritos");
    op = Convert.ToInt32(Console.ReadLine());
    switch (op) {
        case 1:
            Console.WriteLine("Son 30 pesos desea continuar");
            Console.WriteLine("Si");
            Console.WriteLine("No");
            op2 = Console.ReadLine();

            if (op2 == "Si" || op2 == "si")
            {
                Console.WriteLine("Disfrute su bebida");
            }
            else {
                Console.WriteLine("Desea elegir otro refrsco?");
                Console.WriteLine("Si");
                Console.WriteLine("No");
                op2 = Console.ReadLine();
                switch (op2)
                {
                    case "Si":
                    case "si":
                        repetir = true;
                        break;
                    case "No":
                    case "no":
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("esa opcion no existe se tomara como un no");
                        repetir = false;
                        break;
                }
            }
            break;
        case 2:
            Console.WriteLine("Son 10 pesos desea continuar");
            Console.WriteLine("Si");
            Console.WriteLine("No");
            op2 = Console.ReadLine();

            if (op2 == "Si" || op2 == "si")
            {
                Console.WriteLine("Disfrute su bebida");
            }
            else
            {
                Console.WriteLine("Desea elegir otro refrsco?");
                Console.WriteLine("Si");
                Console.WriteLine("No");
                op2 = Console.ReadLine();
                switch (op2)
                {
                    case "Si":
                    case "si":
                        repetir = true;
                        break;
                    case "No":
                    case "no":
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("esa opcion no existe se tomara como un no");
                        repetir = false;
                        break;
                }
            }
            break;
        case 3:
        Console.WriteLine("Son 90 pesos desea continuar");
        Console.WriteLine("Si");
        Console.WriteLine("No");
        op2 = Console.ReadLine();

        if (op2 == "Si" || op2 == "si")
        {
            Console.WriteLine("Disfrute su bebida");
        }
        else
        {
            Console.WriteLine("Desea elegir otro refrsco?");
            Console.WriteLine("Si");
            Console.WriteLine("No");
            op2 = Console.ReadLine();
                switch (op2)
                {
                    case "Si":
                    case "si":
                        repetir = true;
                        break;
                    case "No":
                    case "no":
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("esa opcion no existe se tomara como un no");
                        repetir = false;
                        break;
                }
            }
        break;
    case 4:
        Console.WriteLine("Son 100 pesos desea continuar");
        Console.WriteLine("Si");
        Console.WriteLine("No");
        op2 = Console.ReadLine();

        if (op2 == "Si" || op2 == "si")
        {
            Console.WriteLine("Disfrute su bebida");
        }
        else
        {
            Console.WriteLine("Desea elegir otro refrsco?");
            Console.WriteLine("Si");
            Console.WriteLine("No");
            op2 = Console.ReadLine();
                switch (op2)
                {
                    case "Si":
                    case "si":
                        repetir = true;
                        break;
                    case "No":
                    case "no":
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("esa opcion no existe se tomara como un no");
                        repetir = false;
                        break;
                }
            }
        break;
     default:
            Console.WriteLine("Esa opcion no es valida adios");
            repetir = false;
               break;

}
}while(repetir == true);