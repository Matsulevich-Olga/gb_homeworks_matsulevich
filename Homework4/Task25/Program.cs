int power(int A, int B)
{
    int power = A;
    for (int i = 2; i <= B; i++)
    {
        power = power * A;
    }
    return power;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите cтепень: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(power(A, B));