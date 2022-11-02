int[] readPoint()
{
    int[] point =   { 0, 0, 0 };
    for (int i = 0; i <= 2; i++)
    {
        Console.Write("Введите координату: ");
        point[i] = Convert.ToInt32(Console.ReadLine());
    }
    return point;
}

Console.WriteLine("Введите координаты точки А");
int[] pointA = readPoint();
Console.WriteLine("Введите координаты точки B");
int[] pointB = readPoint();
double length = 0;
for (int i = 0; i <= 2; i++)
{
    length = length + (pointB[i] - pointA[i]) * (pointB[i] - pointA[i]);
}
Console.WriteLine(Math.Round(Math.Sqrt(length),2));
