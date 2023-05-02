// Принимает координаты точки (х!=0, у!=0). Выдает номер четверти, в которой находится эта точка.

void Quarter(int x, int y)
{
    if (x==0 || y==0)
        Console.WriteLine ("не соответствует условию");
    if (x>0 && y>0)
        Console.WriteLine (" I ");
    if (x<0 && y>0)
        Console.WriteLine (" II ");
    if (x<0 && y<0)
        Console.WriteLine (" III ");
    if (x>0 && y<0)
        Console.WriteLine (" IV ");

}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarter(num_1, num_2);