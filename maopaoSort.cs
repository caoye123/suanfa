//

int[] array = {232,22,5,9,1,7,3,0};
BSort(array);
foreach (int i in array)
{
    Console.Write(i+" ");
}

static void BSort(int[] array) {
    var length = array.Length;
    for (int i = 0; i < length - 1; i++) {
        bool swap = false;
        int temp = 0;
        for (int j = 0; j < length - i - 1; j++)
        {
            if(array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swap = true;
            }
        }
        if (!swap)
        {
            break;
        }
    }
}