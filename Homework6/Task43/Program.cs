// Считаем координату x точки пересечения.

double calculateX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

// Считаем координату y точки пересечения.

double calculateY(double b1, double k1, double x)
{
    return k1 * x + b1;
}

// Решение.

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = calculateX(b1, k1, b2, k2);
double y = calculateY(b1, k1, x);
Console.WriteLine($"({x},{y})");

