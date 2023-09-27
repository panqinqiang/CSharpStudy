using CSharpStudy._20230927;
using CSharpStudy2._20230927;

namespace CSharpStudy;

public class Class1
{
    static void Main(string[] args)
    {
        int[] arr = { 12, 4, 5, 6, 7, 3, 1, 15, 2, 10 };
        Console.WriteLine("原始数组：");
        PrintArray(arr);

        QuickSortTest.QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("排序后的数组：");
        PrintArray(arr);
    }
    
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}