int day = 1;
if (day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine(day + " - да");
    }
    else
    {
        Console.WriteLine(day + " - нет");
    }
}
else
{
    Console.WriteLine("не является днем недели");
}
