// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double X1, double Y1, double X2, double Y2)
{
    return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
}

Console.WriteLine(Distance(3, 6, 2, 1));