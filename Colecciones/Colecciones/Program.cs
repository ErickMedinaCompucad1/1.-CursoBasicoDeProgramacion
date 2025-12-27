// See https://aka.ms/new-console-template for more information

//Colecciones ^
int[] arr = { 1, 2, 3, 4, 5};

int lastElemnt = arr[^1];//Selecciona el ultimo elemento
int secondLastElemnt = arr[^2];//Selecciona el penultimo elemento

Console.WriteLine(lastElemnt);
Console.WriteLine(secondLastElemnt);
Console.ReadKey();


Console.ForegroundColor = ConsoleColor.Yellow;
TimeRemaining countdown = new TimeRemaining()
{
    buffer =
    {
        [^1] = 1,
        [^2] = 2,
        [^3] = 3,
        [^4] = 4,
        [^5] = 5,
        [^6] = 6,
        [^7] = 7,
        [^8] = 8,
        [^9] = 9,
        [^10] = 10,
    }
};

foreach (int i in countdown.buffer) {
    Console.WriteLine(i);
}
Console.ReadKey();
class TimeRemaining
{
    public int[] buffer { get; set; } = new int[10];
}

