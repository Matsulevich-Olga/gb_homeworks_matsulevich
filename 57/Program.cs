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

// Cортировка строк двумерного массива.

static int[,] BubbleSort(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
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
