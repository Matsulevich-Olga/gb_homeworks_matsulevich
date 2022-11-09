//Cоздание трехмерного массива.

int[,,] Create3DArray(int n, int m, int l)
{
    int[,,] array = new int[n, m, l];
    return array;
}

// Заполнение трехмерного массива.

int[,,] fill3DArray(int[,,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(min, max);
            }
    return array;
}

//Печать трехмереного массива.

void print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++, Console.WriteLine(""))
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[j, k, i]} ({j},{k},{i}) \t");
            }
}

//Решение.

int[,,] array = Create3DArray(2, 2, 2);
array = fill3DArray(array, 10, 99);
print3DArray(array);

