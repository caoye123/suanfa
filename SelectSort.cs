//

int[] array = new int[] {12,243,45,67,12,3,99 };

SelectSort(array);

foreach(int i in array)
{
    Console.Write(i + " ");
}

static void SelectSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int min = i;
        int temp = 0;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[min])
            {
                min = j;
            }
        }
        temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

