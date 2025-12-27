// See https://aka.ms/new-console-template for more information

List<string> weekDays = new List<string> { "Sun", "Mon", "Tue", "Wed", "Fri", "Sat"};
List<string> weekDays2 = [ "Sun", "Mon", "Tue", "Wed", "Fri", "Sat" ];
string[] weekDays3 = [ "Sun", "Mon", "Tue", "Wed", "Fri", "Sat" ];


Console.ForegroundColor = ConsoleColor.Yellow;
foreach (var day in weekDays)
{
    Console.WriteLine(day);
}

Console.ForegroundColor = ConsoleColor.Green;
foreach (var day in weekDays2)
{
    Console.WriteLine(day);
}

Console.ForegroundColor = ConsoleColor.Red;
foreach (var day in weekDays3)
{
    Console.WriteLine(day);
}

Console.ForegroundColor = ConsoleColor.Blue;

char[] vowels = [ 'a', 'e', 'i', 'o', 'u' ];
char[] consonants =
[
    'b','c','d','f','g','h','j','k','l','m',
    'n','p','q','r','s','t','v','w','x','z'
];
//Con los .. se concatenan los arreglos
char[] alphabet = [..vowels, ..consonants, 'y'];
foreach (var letter in alphabet)
{
    Console.WriteLine(letter);
}
Console.ReadKey();