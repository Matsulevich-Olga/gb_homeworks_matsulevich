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

//Метод подсчета четных чисел в массиве.

int countEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//Решение.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = creadeArray(n);
array = fillArray(array, 100, 999);
printArray(array);
Console.WriteLine($"-> {countEven(array)}");

