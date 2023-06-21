using System;

class BubbleSort {
    static void BubbleSort(int[] arr) {
        int unsortedUntilIndex = arr.Length - 1;
        bool sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < unsortedUntilIndex; i++) {
                if (arr[i] > arr[i + 1]) {
                    sorted = false;
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            unsortedUntilIndex--;
        }
    }

    static void Main(string[] args) {
        int[] arr = { 65, 55, 45, 35, 25, 15, 10 };
        BubbleSort(arr);
        foreach (int num in arr) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
