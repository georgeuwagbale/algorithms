using System;

class BinarySearch {
    static string BinarySearch(int[] arr, int value) {
        int lowerBound = 0;
        int upperBound = arr.Length - 1;

        while (lowerBound <= upperBound) {
            int midpoint = (upperBound + lowerBound) / 2;
            int valueAtMidpoint = arr[midpoint];

            if (value == valueAtMidpoint) {
                return $"{value} exists in the given array and its index is {midpoint}.";
            }
            else if (value > valueAtMidpoint) {
                lowerBound = midpoint + 1;
            }
            else if (value < valueAtMidpoint) {
                upperBound = midpoint - 1;
            }
        }

        return $"{value} does not exist in the given array.";
    }

    static void Main(string[] args) {
        int[] arr = { 0, 3, 4, 5, 6 };
        Console.WriteLine(BinarySearch(arr, 0));
    }
}
