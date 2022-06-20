int[] CreateAndFillArray()
{
    int [] array = new int [123];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,999);
    }
    return array;
}

void CountArrayElements(int[] array)
{   int counter = 0;
     for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >=10 && array[i] <=99)
        {
            counter++;
        }
    }
    System.Console.WriteLine($"Кол-во элементов от 10 до 99: {counter}");
}
void ShowArray(int [] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.Write($"{array[i]}  ");
        
    }
    System.Console.WriteLine();
}

int [] arr = CreateAndFillArray();
ShowArray(arr);
CountArrayElements(arr);
