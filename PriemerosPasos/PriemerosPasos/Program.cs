// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double ladoA;
double ladoB;
//Var es para declarar de forma implicita variables
var resultado = 0.0;

Console.WriteLine("Calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor de lado A");
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor de lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

ladoA++;//Suma uno
ladoA--;//Resta uno

resultado = ladoA * ladoB;
Console.WriteLine($"EL area de tu rectangulo es {resultado} de las medida de lado a {ladoA} y el lado b {ladoB}");

Console.ReadKey();

//Operadores aritmeticos
/*
 + Suma
 - Resta
 * Multiplicacion
 / Divicion
 % Division
*/

//Operadores de incremento y decremento
// -- Decremento
// ++ Incremento