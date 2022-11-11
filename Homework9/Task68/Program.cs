using static System.Console;

//Метод вычисление функции Аккермана.

int Accerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 & m > 0)
    {
        return Accerman(m - 1, 1);
    }
    else
    {
        return Accerman(m - 1, Accerman(m, n - 1));
    }
}

//Решение.

WriteLine(Accerman(3, 2));