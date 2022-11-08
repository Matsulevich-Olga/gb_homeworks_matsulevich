//Cоздание двумерного массива.

double[,] createArray(double n, double m)
{
    double[,] array = new double[n, m];
    return array;
}

// Заполнение массива

double[,] fillArray(double[,] array, double min, double max)
{
    Random rand = new Random();
    for (double i = 0; i < array.GetLength(0); i++)
        for (double j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}
//Печать массива

void printArray(double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (double j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

//Решение.

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = createArray(n, m);

array = fillArray(array, 0, 100);
printArray(array);
array = BubbleSort(array);
Console.WriteLine("Отсортированный массив");
printArray(array);

