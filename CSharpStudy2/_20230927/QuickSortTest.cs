namespace CSharpStudy2._20230927;

public class QuickSortTest
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int povotIndex = Patition(arr, left, right);
            QuickSort(arr, left, povotIndex-1);
            QuickSort(arr, povotIndex+1, right);
        }
    }

    private static int Patition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp2;
        return i + 1;
    }
}

