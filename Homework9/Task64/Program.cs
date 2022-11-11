using static System.Console;

//Метод рекурсивного вывода чисел от N до 1.

string RecursiveNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + ", " + RecursiveNumbers(n - 1);
    }
}

//Решение.

WriteLine(RecursiveNumbers(8));

