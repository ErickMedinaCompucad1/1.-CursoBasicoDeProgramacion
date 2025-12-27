// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Red;

//HashSet no permite elementos duplicados
HashSet<string> hashSet = new HashSet<string>();
hashSet.Add("a");
hashSet.Add("b");
hashSet.Add("c");
hashSet.Add("d");
foreach (var item in hashSet)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//SortedSet organiza una lista en acendente
Console.ForegroundColor = ConsoleColor.Green;
SortedSet<string> sortedSet = new SortedSet<string>();
sortedSet.Add("d");
sortedSet.Add("b");
sortedSet.Add("a");
sortedSet.Add("c");
Console.WriteLine($"{sortedSet.ElementAt(1)}");
foreach (var item in sortedSet)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//Dictionary almacena pares clave-valor
Console.ForegroundColor = ConsoleColor.Yellow;
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "uno");//Se deven de acomodar como el tipo de datos
dictionary.Add(2, "dos");
dictionary.Add(3, "tres");
Console.WriteLine($"{dictionary[2]}");
//De esta forma es lo mismo que el diccionario pero en lista asendente
//SortedList<string, double> fruitcost = new SortedList<string, double>();
Dictionary<string, double> fruitcost = new Dictionary<string, double>();
fruitcost.Add("manzana", 3.14);
fruitcost.Add("mango", 2.71);
fruitcost.Add("naranja", 19.04);

Console.WriteLine($"{fruitcost["mango"]}");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Blue;
foreach (KeyValuePair<string, double> item in fruitcost) 
{ 
    Console.WriteLine(item);//Esto tra el par clave-valor
    //Estos de abajo traen por separado la clave y el valor
    Console.WriteLine($"El precio de {item.Key} es igual a = {item.Value}");
}
Console.ReadKey();