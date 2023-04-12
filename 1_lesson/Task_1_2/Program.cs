Console.WriteLine("Введите число от 1 до 7 включительно");
int x = int.Parse(Console.ReadLine()!);
if ( x == 1)
{
    Console.WriteLine("Monday");
}
else if ( x == 2 )
{
    Console.WriteLine("Thuesday");
}
else if ( x == 3 )
{
    Console.WriteLine("Wednesday");
}
else if ( x == 4 )
{
    Console.WriteLine("Thursday");
}
else if ( x == 5 )
{
    Console.WriteLine("Friday");
}
else if ( x == 6 )
{
    Console.WriteLine("Saturday");
}
else if ( x == 7 )
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Вы ввели не то число, попробуйте снова. Введите число от 1 до 7 включительно");
}