// See https://aka.ms/new-console-template for more information
int[] arr = { 1, 2, 3, 4, 5 };
Console.ForegroundColor = ConsoleColor.Yellow;
PrintNumbers(5);
Console.ForegroundColor = ConsoleColor.Blue;
PrintNumbers(5,2);
Console.ForegroundColor = ConsoleColor.Red;
PrintNumbers(arr);
PrintNumbers(1,2,3,4,5,6,7,8,9);
Console.ReadKey();

partial class Program
{
    // Overload 1: recibe int
    static void PrintNumbers(int number)
    {
        Console.WriteLine(number);
    }

    // Overload 2: recibe string
    static void PrintNumbers(int num1, int num2)
    {
        Console.WriteLine(num2 * num1);
    }

    //Esta funcion se puede declarar asi
    ///static void PrintNumbers(int[] numbers)
    //Pero se puede hacer esto tambien
    //Si usamos paramas, ademas de mandar cualquier cantidad de parametros, se concatenan
    //static void PrintNumbers(params int[] numbers)
    //
    static void PrintNumbers(params IEnumerable<int> numbers)
    {
        foreach (var item in numbers) {  
            Console.WriteLine(item); 
        }
    }

}