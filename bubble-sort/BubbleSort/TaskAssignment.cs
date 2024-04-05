namespace BubbleSort;

public class TaskAssignment
{
    public static int[] BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length-1; j++)
            {
                var tmp = array[j];

                // Order of swapping
                if (array[j] < array[j+1])
                {
                    array[j] = array[j+1];
                    array[j+1] = tmp;
                }
            }
        }
        return array;
    }
}