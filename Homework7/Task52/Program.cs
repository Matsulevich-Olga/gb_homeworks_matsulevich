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

//Cоздание одномерного массива.

double[] createDoubleArray(int n)
{
    double[] array = new double[n];
    return array;
}

double[] fillDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
    return array;
}


//Печать одномерного массива. 

void printDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Метод подсчета среднего арифметического строк двумерного массива и записи в массив вещественных чисел.

double[] AverageArray(int[,] array)
{
    double[] avgArray = createDoubleArray(array.GetLength(0));
    avgArray = fillDoubleArray(avgArray);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avgArray[i] = avgArray[i] + array[i, j];
        }
        avgArray[i] = avgArray[i] / array.GetLength(1);
    }
    return avgArray;
}

//Решение. 

int[,] array = createArray(5, 5);
array = fillArray(array, 0, 10);
printArray(array);
Console.WriteLine("");
double[] avgArray = AverageArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
printDoubleArray(avgArray);