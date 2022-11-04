//Cоздание массива.

int[] creadeArray(int n)
{
    int[] array = new int[n];
    return array;
}

//Заполнение массива рандомными значениями.

int[] fillArray(int[] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

//Печать массива. 

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Подсчет суммы элентов массива с нечетными индексами.

int sumOddIndexDigits(int[] array)

{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

//Решение.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = creadeArray(n);
array = fillArray(array, -100, 100);
printArray(array);
Console.WriteLine($"-> {sumOddIndexDigits(array)}");
