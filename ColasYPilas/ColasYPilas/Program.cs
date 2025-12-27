// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;
using System.Collections.Generic;

// =======================
// PILAS (Stack) - LIFO
// Last In, First Out: el último que entra es el primero que sale
// =======================

string word;          // Variable para guardar temporalmente cada palabra que se saque de la pila
int counter;          // Guardará la cantidad de elementos que hay en la pila
Stack greetingStack;  // Pila NO genérica (System.Collections.Stack). Guarda objetos (object)
//Stack<string> greetingStack;  // Pila genérica (System.Collections.Generic.Stack<T>). Guarda strings

// Usando PUSH y POP
Console.ForegroundColor = ConsoleColor.Green;  // Cambia el color del texto en consola a verde

greetingStack = new Stack();  // Crea la pila vacía

greetingStack.Push("Hola");   // Push = apilar: agrega un elemento en la parte superior (top) de la pila
greetingStack.Push("buenos"); // Cada Push mete el elemento "encima" del anterior
greetingStack.Push("dias");   // "dias" queda en la cima (será el primero en salir)

// Count devuelve cuántos elementos hay actualmente en la pila
counter = greetingStack.Count;
Console.WriteLine($"Hay {counter} elementos en la pila");

// Recorremos exactamente la cantidad de elementos que había al inicio
// IMPORTANTE: aquí NO podemos usar greetingStack.Count en el for,
// porque Pop() va disminuyendo el Count y podrías terminar recorriendo menos o confundir el control del ciclo.
for (int i = 0; i < counter; i++)
{
    // Pop = desapilar: saca y devuelve el elemento que está hasta arriba.
    // Como el Stack es NO genérico, Pop() devuelve object, por eso hacemos cast a string.
    word = (string)greetingStack.Pop();

    // Imprime la palabra que acabamos de sacar.
    // El orden de salida será: "dias", "buenos", "Hola" (por LIFO)
    Console.WriteLine(word);
}
Console.WriteLine($"Hay {counter} elementos en la pila final");
Console.ReadKey();

//Usando PEEK
Console.ForegroundColor = ConsoleColor.Magenta;
greetingStack.Push("Hola");   
greetingStack.Push("buenos"); 
greetingStack.Push("dias");

counter = greetingStack.Count;
Console.WriteLine($"Hay {counter} elementos en la pila inicial");

for (int i = 0; i < counter; i++)
{
    // Peek = mirar: devuelve el elemento que está hasta arriba sin sacarlo de la pila.
    word = (string)greetingStack.Peek();//Se pone primero por que si la pila esta vacia da error
    Console.WriteLine(word);

    word = (string)greetingStack.Pop();
    Console.WriteLine(word);
}

Console.WriteLine($"Hay {counter} elementos en la pila final");
Console.ReadKey();

//Usando CLEAR y CONTAINS
Console.ForegroundColor = ConsoleColor.Yellow;

greetingStack.Push("Hola");
greetingStack.Push("buenos");
greetingStack.Push("dias");

// Contains revisa si dentro de la pila existe un elemento igual al que le pasas.
// Aquí estás buscando una cadena "dias" (string).
if (greetingStack.Contains("dias"))
{
    // Clear vacía completamente la pila (elimina todos los elementos).
    greetingStack.Clear();
}
Console.WriteLine($"Hay {greetingStack.Count} elementos en la pila final");
Console.ReadKey();


Console.WriteLine("=======================================================");
//Colas
Console.ForegroundColor = ConsoleColor.Red;  
Queue greetingQueue = new Queue();  
greetingQueue.Enqueue("Hola");
greetingQueue.Enqueue("buenos");
greetingQueue.Enqueue("dias");

counter = greetingQueue.Count;
Console.WriteLine($"Hay {counter} elementos en la cola inicial");

for(int i = 0; i<counter; i++) 
{ 
    word = (string)greetingQueue.Peek();
    Console.WriteLine($"La siguiente palabra es {word}");
    word = (string)greetingQueue.Dequeue();
    Console.WriteLine($"La palabra que sale es {word}");
}

Console.ReadKey();

//Usando CLEAR y CONTAINS
Console.ForegroundColor = ConsoleColor.Green;

greetingQueue.Enqueue("Hola");
greetingQueue.Enqueue("buenos");
greetingQueue.Enqueue("dias");


if (greetingQueue.Contains("dias"))
{
    greetingStack.Clear();
}
Console.WriteLine($"Hay {greetingStack.Count} elementos en la cola final");
Console.ReadKey();