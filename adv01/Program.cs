using System;

#region Q1 Optimized Bubble Sort

class BubbleSortOptimized
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                   
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

           
            if (!swapped)
                break;
        }
    }
}


#endregion
#region Q2
#region 1 Create Generic Class Range<T>
public class Range<T> where T : IComparable<T>
{
    public T Min { get; private set; }
    public T Max { get; private set; }


    #endregion
    #region 2  Constructor to define the range
    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("Min must be less than or equal to Max.");

        Min = min;
        Max = max;
    }


    #endregion
    #region 3  Method: Check if value is inside range
    public bool IsInRange(T value)
    {
        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }
}
#endregion
#endregion
