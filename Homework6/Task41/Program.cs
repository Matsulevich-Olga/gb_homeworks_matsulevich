//Преобразуем строку в массив строк.

string[] stringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}


//Преобразуем массив сторок в массив целых чисел.

int[] strToIntArray(string[] stringArray)
{
    int[] intArray = new int[stringArray.Length];
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return intArray;
}

//Считаем количество положительных чисел.

int positiveCount(int[] intArray)
{
    int count = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0)
        {
            count++;
        }

    }
    return count;
}

//Решение.

Console.Write("Введите числа: ");
string str = Console.ReadLine();
string[] strArray = stringToArray(str);
int[] intArray = strToIntArray(strArray);
Console.WriteLine(positiveCount(intArray));




