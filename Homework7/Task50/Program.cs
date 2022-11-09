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

//Метод получение числа с консоли.

int ReadNumber(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Метод, который сообщает, есть ли вводимые координаты в двумерном массиве.

bool IsCoordinatesExist(int[,] array, int x, int y)
{
    if (x <= array.GetLength(0) & y <= array.GetLength(1))
    {
        return true;
    }
    else return false;
}

//Решение

int[,] array = createArray(10, 10);
array = fillArray(array, 0, 100);
printArray(array);

Console.WriteLine("");
int x = ReadNumber("Введите координату x");
int y = ReadNumber("Введите координату y");

if (IsCoordinatesExist(array, x, y))
{
    Console.WriteLine(array[x - 1, y - 1]);
}
else
{
    Console.WriteLine($"{x},{y} - Такого элемента нет");
}



