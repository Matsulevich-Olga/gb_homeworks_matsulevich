//принимаем на вход пятизначное число
int number = 0;
while (number < 10000 || number > 99999)
{
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 10000 || number > 99999)
    {
        Console.WriteLine("Число не пятизначное");
    }
}

//cравниваем первую и поледнюю цифру, вторую и четвертую в числе
if (number / 10000 == number % 10)
{
    if (number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("Да");
    }
    else { Console.WriteLine("Нет"); }
}
else { Console.WriteLine("Нет"); }
