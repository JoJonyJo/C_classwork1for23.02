// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] InputRandomMassiv(int lengthMas, int minRangeMas, int maxRangeMas)
{
    int[] masRandom = new int[lengthMas]; // Задаем массив
    for (int i = 0; i < lengthMas; i++)
    {
        masRandom[i] = new Random().Next(minRangeMas, maxRangeMas); // Случайные числа в диапозоне
    }
    return masRandom;
}
// Вывод массива
void PrintMassive(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]}");
    Console.WriteLine();
}

void MasConverter(int[] arry)
{
    for (int i = 0; i < arry.Length; i++)
        arry[i] = -arry[i]; 
}

Console.WriteLine("Введите длину массива");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа");
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassiv(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);
MasConverter(masRandom);
PrintMassive(masRandom);