void IsNumberHere(int[] array, int Number)
{
    bool flag = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(Number == array[i])
        {
            flag = true;
            break;
        }
    }
    if(flag ==true)
    {
        System.Console.WriteLine("Число есть");
    }
    else
    {
        System.Console.WriteLine("Числа нет");
    }
    
}
int [] arr = new int[] {2,4,5,6,7};
int Number = 5;
int Number2 = 10;
IsNumberHere(arr, Number);
IsNumberHere(arr, Number2);
