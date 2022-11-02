int[] randomArray(int n)
{
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(0, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}

Console.Write("Введите число: ");
int[] randArray = randomArray(Convert.ToInt32(Console.ReadLine()));