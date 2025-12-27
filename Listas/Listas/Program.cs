// See https://aka.ms/new-console-template for more information


Console.ForegroundColor = ConsoleColor.Red;

//Crear una instancia de una lista
List<int> list1 = new List<int>();
list1.Add(10);
list1.Add(20);
list1.Add(30);
list1.Add(40);
list1.Add(50);
list1.Add(60);
list1.Add(70);
ShowListContains(list1);
Console.ReadLine();

//Contains y remove
if (list1.Contains(50)) 
{ 
    list1.Remove(50);
}
Console.ForegroundColor = ConsoleColor.Green;
ShowListContains(list1);
Console.ReadKey();



Console.ForegroundColor = ConsoleColor.Yellow;
if (!list1.Contains(50))
{
    //Insert
    list1.Insert(5,50);
    Console.WriteLine("Se ha insertado el valor 50 en la posición 5");
}
ShowListContains(list1);
Console.ReadKey();

//Crear una lista con valores iniciales
Console.ForegroundColor = ConsoleColor.Cyan;
List<int> list2 = new List<int>() { 80,90,100,110 };
ShowListContains(list2);
Console.ReadKey();

//Combinar listas
list2.InsertRange  (0, list1);//Insertar list1 al inicio de list2
Console.ForegroundColor = ConsoleColor.Magenta;
ShowListContains(list2);
Console.ReadKey();

static void ShowListContains(List<int> list)
{
    Console.WriteLine("Contenido de la lista:");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}