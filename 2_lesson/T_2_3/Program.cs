void Def(int num1, int num2)
{
    if(num1 % num2 == 0)
        Console.WriteLine("Кратно");
    else 
        Console.WriteLine("Не кратно, остаток " + num2 %num1);
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Def(a, b);