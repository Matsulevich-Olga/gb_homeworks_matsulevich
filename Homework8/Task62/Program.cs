// Спиральное заполнение массива. 

int[,] FillSpiral(int n)
{
    int[,] array = new int[n, n];

    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    while (count > 0)
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            array[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            array[sum / n, sum % n] = pos++;
        }
    }
    return array;
}


//Печать массива

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

//Решение.

int[,] array = FillSpiral(4);
PrintArray(array);
