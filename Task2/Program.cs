int[] ChangeSign(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
            array[i] = - array[i];
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.Write($"{array[i]}  ");
        
    }
    System.Console.WriteLine();
}

int[] arr = new int [] {1,2,-3,4,5,-6}; 
ShowArray(arr);
int[] newArr =ChangeSign(arr);
ShowArray(newArr);