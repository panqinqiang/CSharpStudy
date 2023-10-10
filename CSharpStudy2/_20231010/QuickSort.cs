using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApplication1._20231010;

public class QuickSort
{
    public static void QuickSort1010(int[] arr, int left, int right)
    {
        if (left < right)  //递归终止
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort1010(arr, left, pivotIndex-1);
            QuickSort1010(arr, pivotIndex, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right);
        return i + 1;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}