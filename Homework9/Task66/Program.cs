using static System.Console;

//Метод рекурсивного подсчета суммы чисел от M до N.

int RecursiveSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + RecursiveSum(m, n - 1);
    }
}

//Решение.

WriteLine(RecursiveSum(4, 8));

