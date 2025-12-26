// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//De esta forma se declara un constante
const double Pi = 3.14;

var resultado = 0d; //Si queremos que detecte flotantes se pone f
Console.WriteLine("Bienvenido calculemos circulos");

//PI * radio*radio

Console.WriteLine("Ingrese el valor del radio");
double radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;

Console.WriteLine($"El area de tu circulo es de {resultado}");