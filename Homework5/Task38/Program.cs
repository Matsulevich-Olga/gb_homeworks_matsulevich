//Cоздание массива.

double[] creadeArray(int n)
{
    double[] array = new double[n];
    return array;
}

//Заполнение массива рандомными значениями.

double[] fillArray(double[] array, double min, double max)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        var next = rand.NextDouble();
        array[i] = min + next * (max - min);
    }
    return array;
}

//Печать массива. 

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Нахождение максимального элемента в массиве.

double maxValue(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
return max;
}

//Нахождение минимального элемента в массиве.

double minValue(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
return min;
}

//Решение.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = creadeArray(n);
array = fillArray(array, 0, 100);
printArray(array);
Console.WriteLine($"-> {maxValue(array) - minValue(array)}");
