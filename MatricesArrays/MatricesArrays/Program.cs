// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Un array es una estructura de datos que guarda una colección de elementos del mismo 
//tipo en una sola variable, y se accede a cada elemento mediante un índice (empieza en 0).
//En C# los arrays tienen tamaño fijo: se define al crearlos y ya no cambia.
//Ejemplo típico: int[], string[].Un array es una estructura de datos que guarda una 
//colección de elementos del mismo tipo en una sola variable, y se accede a cada elemento mediante un índice (empieza en 0).
//En C# los arrays tienen tamaño fijo: se define al crearlos y ya no cambia.
//Ejemplo típico: int[], string[].


//Declarar un array
int[] array1 = new int[3];
array1[0] = 1;
array1[1] = 2;
array1[2] = 3;

Console.WriteLine($"Array1[]: {array1[0]}");
Console.WriteLine($"Array1[]: {array1[1]}");
Console.WriteLine($"Array1[]: {array1[2]}");
Console.ReadKey();

//Con datos ya inicializados
Console.ForegroundColor = ConsoleColor.Yellow;
int[] array2 = new int[] { 10, 32, 83 };
//de esta forma se barre un array
foreach (var n in array2)
{ 
    Console.WriteLine($"Array2[]: {n}");
}
Console.ReadKey();

//Forma corta de declarar un array
string[] array3 = { "Hola", "Mundo"};
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Saludo = {array3[0]} {array3[1]}");
Console.ReadKey();


//Arrrays de jagged array 
Console.ForegroundColor = ConsoleColor.Red;
int[][] arrayOfArrays = new int[2][];
arrayOfArrays[0] = new int[] { 1,};
arrayOfArrays[1] = new int[] { 2, 3, 4 };

foreach (int[] item in arrayOfArrays) 
{
    foreach (int subItem in item) 
    { 
        Console.WriteLine($"{subItem}");
    }
}
Console.ReadKey();

//Esto es para saber el numero de elementos en un array
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"El array1 tiene {array1.Length} elementos");
Console.WriteLine($"El array2 tiene {array2.Length} elementos");
Console.WriteLine($"El array3 tiene {array3.Length} elementos");
Console.WriteLine($"El arrayOfArrays tiene {arrayOfArrays.Length} elementos");
Console.ReadKey();

//Numero de dimsensiones de arrays
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"El array1 tiene {array1.Rank} dimensiones");
Console.WriteLine($"El array2 tiene {array2.Rank} dimensiones");
Console.WriteLine($"El array3 tiene {array3.Rank} dimensiones");
Console.WriteLine($"El arrayOfArrays tiene {arrayOfArrays.Rank} dimensiones");
Console.ReadKey();



//Una matriz en C# es un array multidimensional rectangular, es decir, 
//un arreglo con 2 o más dimensiones donde todos los “renglones” tienen el mismo número de “columnas”.
//Se declara con comas en los corchetes: int[,] (2D), int[,,] (3D).
//Se accede con varios índices: matriz[fila, columna].

//Arrays multidimensionales
Console.ForegroundColor = ConsoleColor.DarkGray;
int[,] students = new int[2, 3];
students[0, 0] = 8;
students[0, 1] = 9;
students[0, 2] = 10;

students[1, 0] = 5;
students[1, 1] = 6;
students[1, 2] = 7;

for (int fila = 0; fila < students.GetLength(0); fila++)
{
    for (int col = 0; col < students.GetLength(1); col++)
    {
        Console.WriteLine($"students[{fila},{col}] = {students[fila, col]}");
    }
}
Console.ForegroundColor = ConsoleColor.Blue;
foreach (int item in students)
{
    Console.WriteLine(item);
}

Console.ReadKey();