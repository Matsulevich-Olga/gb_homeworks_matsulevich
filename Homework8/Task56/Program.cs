//Cоздание двумерного массива.
int[,] createArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

// Заполнение массива
int[,] fillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}

//Печать массива
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

//Метод нахождения строки с наименьшей суммой элементов.

int FindMinSumIndex(int[,] array)
{
    int index = 1;
    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min = min + array[0, j];
    }
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }

        if (sum < min)
        {
            min = sum;
            index = i + 1;
        }
        sum = 0;
    }
    return index;
}

//Решение.

int[,] array = createArray(4, 6);
array = fillArray(array, 0, 10);
printArray(array);
Console.WriteLine("");
Console.WriteLine(FindMinSumIndex(array) + " cтрока");

