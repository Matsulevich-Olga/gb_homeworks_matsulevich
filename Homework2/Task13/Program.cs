int number = 32679;
int n = number;
if (n >= 100)
{
    while (n >= 1000)
    {
        n = n / 10;
    }
    n = n % 10;
    Console.WriteLine("Третья цифра числа "+number+" - "+n);
} else
{
    Console.WriteLine("Третьей цифры нет");
}
