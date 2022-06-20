int[] CreateAndFillArray()
{
    int [] array = new int [12];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] arr = CreateAndFillArray();


void ShowArray(int [] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.Write($"{array[i]}  ");
        
    }
    System.Console.WriteLine();
}
ShowArray(arr);

void SumPlusAndMinus(int[] arr)
{
    int MaxSum = 0;
    int MinSum = 0;
    for(int i = 0; i< arr.Length; i++)
    {
        
        if (arr[i]>=0)
        {
                MaxSum = MaxSum + arr[i];
                
        }
        else
        {
                MinSum = MinSum + arr[i];
        }
    }
    System.Console.WriteLine($"{MinSum}  {MaxSum}");
}
SumPlusAndMinus(arr);

