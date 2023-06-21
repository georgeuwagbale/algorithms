using System;
using System.Collections.Generic;

class Program
{
    static int GetMaximumValue(int[] arr, int arrLength)
    {
        int max = arr[0];
        for (int i = 1; i < arrLength; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static void CountingSortPositive(int[] arr, int exp, int length)
    {
        int[] countArray = new int[10];
        for (int i = 0; i < length; i++)
        {
            countArray[(arr[i] / exp) % 10]++;
        }
        for (int i = 1; i < 10; i++)
        {
            countArray[i] += countArray[i - 1];
        }
        int[] output = new int[length];
        for (int i = length - 1; i >= 0; i--)
        {
            int current = arr[i];
            int positionInArray = countArray[(current / exp) % 10] - 1;
            output[positionInArray] = current;
            countArray[(current / exp) % 10]--;
        }
        for (int i = length-1; i >= 0; i++)
        {
            arr[i] = output[i];
        }
    }

    static void CountingSortNegative(int[] arr, int exp, int length)
    {
        int[] countArray = new int[10];
        for (int i = 0; i < length; i++)
        {
            countArray[9 - ((-arr[i] / exp) % 10)]++;
        }
        for (int i = 1; i < 10; i++)
        {
            countArray[i] += countArray[i - 1];
        }
        int[] output = new int[length];
        for (int i = length - 1; i >= 0; i--)
        {
            int current = arr[i];
            int positionInArray = countArray[9 - ((-current / exp) % 10)] - 1;
            output[positionInArray] = current;
            countArray[9 - ((-current / exp) % 10)]--;
        }
        for (int i = 0; i < length; i++)
        {
            arr[i] = output[i];
        }
    }

    static void RadixSort(int[] arr, int length)
    {
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        for (int i = 0; i < length; i++)
        {
            if (arr[i] >= 0)
            {
                positive.Add(arr[i]);
            }
            else
            {
                negative.Add(arr[i]);
            }
        }

        if (positive.Count > 0)
        {
            int maxPositiveValue = GetMaximumValue(positive.ToArray(), positive.Count);
            for (int exp = 1; maxPositiveValue / exp > 0; exp *= 10)
            {
                CountingSortPositive(positive.ToArray(), exp, positive.Count);
            }
        }

        if (negative.Count > 0)
        {
            int maxNegativeValue = GetMaximumValue(negative.ToArray(), negative.Count);
            for (int exp = 1; maxNegativeValue / exp > 0; exp *= 10)
            {
                CountingSortNegative(negative.ToArray(), exp, negative.Count);
            }
        }

        int posIndex = positive.Count - 1;
        int negIndex = 0;
        for (int i = 0; i < length; i++)
        {
            if (negIndex < negative.Count)
            {
                arr[i] = negative[negIndex];
                negIndex++;
            }
            else
            {
                arr[i] = positive[posIndex];
                posIndex--;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 1, 0, 4, 5, 7, -3, 9, 2 };
        int length = arr.Length;
        RadixSort(arr, length);
        Console.Write("[");
        for (int i = 0; i < length - 1; i++)
        {
            Console.Write(arr[i] + ",");
        }
        Console.WriteLine(arr[length - 1] + "]");
    }
}
