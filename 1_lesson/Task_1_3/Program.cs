Console.Write("Введите положительное число");
int x = int.Parse(Console.ReadLine()!);
int y = -x;
while ( y <= x )
{
    Console.Write($"{y} ");
    y++;
}