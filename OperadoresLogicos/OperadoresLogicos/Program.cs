// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


bool valor3;
//De esta forma se pueden crear variaas variables
var (valor1, valor2) = (true, false);

//Operadores Logicos
//AND &&
//True && True = True
//false && True = false
//True && false = false
//false && false = false
Console.WriteLine("--AND--");
valor3 = valor1 && valor2; //False
Console.WriteLine(valor3);
valor3 = valor1 && valor1; //True
Console.WriteLine(valor3);


//OR ||
//True || True = True
//false || True = True
//True || false = True
//false || false = false
Console.WriteLine("--OR--");
valor3 = valor1 || valor2; //True
Console.WriteLine(valor3);
valor3 = valor1 || valor1; //True
Console.WriteLine(valor3);
valor3 = valor2 || valor2; //False
Console.WriteLine(valor3);


//NOT !
//Cambia el valor booleano a su opuesto
Console.WriteLine("--NOT--");
valor3 = !valor1;//True =  false
Console.WriteLine(valor3);


//XOR ^
//Comapra dos valores y devuelve true si uno es verdadero y el otro es falso
Console.WriteLine("--XOR--");
valor3 = valor2 ^ valor1;//True
Console.WriteLine(valor3);

Console.ReadKey();