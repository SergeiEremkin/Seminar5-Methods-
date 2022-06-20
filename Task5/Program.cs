int[] FindComposition(int[] array)
{  int[] result;
    if (array.Length % 2 == 0)
    {
         result = new int[array.Length / 2];
    }
    else
    {
         result = new int[array.Length / 2 + 1];
    }
    int Composition;
    for (int i = 0; i < array.Length / 2; i++)
    {
        Composition = array[i] * array[array.Length - 1 - i];
        result[i] = Composition;
    }

    if (array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[array.Length / 2];
        return result;
    }
    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
    System.Console.WriteLine();
}
int[] arr = new int[] { 2, 4, 5, 7, 7 };

ShowArray(arr);
int [] newArr = FindComposition(arr);
ShowArray(newArr);
