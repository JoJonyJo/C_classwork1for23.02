// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Multiply (int num)
{
    int Multi = 1;
    for (int i = 1; i <= num; i++)
        Multi *= i;
    return Multi;
}
int A = int.Parse(Console.ReadLine()!);
int res = Multiply(A);
Console.WriteLine(res);