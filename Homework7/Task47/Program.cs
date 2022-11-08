//Cоздание двумерного массива.

double[,] createArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

// Заполнение массива

double[,] fillArray(double[,] array, double min, double max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            var next = rand.NextDouble();
            array[i, j] = min + next * (max - min);
        }
    return array;
}
//Печать массива

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
}

//Метод получение числа с консоли.

int ReadNumber(string str)
{
    Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Решение.
int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] array = createArray(m, n);
array = fillArray(array, -10, 10);
printArray(array);


