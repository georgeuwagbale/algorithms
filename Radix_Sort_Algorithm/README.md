
# Radix Sort Algorithm

## Introduction

Welcome to the Radix Sort Algorithm README! This document aims to introduce you to the Radix sort algorithm, a powerful sorting algorithm used to organize lists of numbers. Whether you're a novice or new to the world of computer science, this guide will break down the Radix sort algorithm into simple steps and provide examples to help you understand its inner workings.

## What is Radix Sort?

Radix sort is a sorting algorithm that sorts numbers by their digits, from the least significant digit (rightmost) to the most significant digit (leftmost). Unlike other sorting algorithms that compare values directly, Radix sort takes advantage of the fact that numbers can be represented digit by digit. By sorting the numbers digit by digit, Radix sort can efficiently organize large sets of numbers.

## How does Radix Sort Work?

Here's a simplified explanation of the Radix sort algorithm:

1. **Identify the Maximum Number**: To determine the number of digits to consider, find the maximum number in the list.
2. **Perform Counting Sort for Each Digit**: Start from the least significant digit (rightmost) and move towards the most significant digit (leftmost). For each digit, use the counting sort algorithm to sort the numbers based on that digit. This process ensures that numbers with the same digit value are grouped together.
3. **Repeat Counting Sort for Each Digit**: After sorting the numbers based on the current digit, repeat the counting sort process for the next digit until all digits have been processed. This step gradually organizes the numbers by each digit, resulting in a fully sorted list.
4. **Final Sorted List**: Once all digits have been processed, the numbers will be sorted in ascending order based on their digits.

## Example

Let's walk through an example to see how Radix sort works. Consider the following list of numbers: **[543, 986, 217, 765, 329]**.

1. We start by identifying the maximum number, which is 986. This tells us that we need to consider three digits (ones, tens, and hundreds).
2. We perform the counting sort for each digit, starting from the least significant digit (ones place). After sorting based on the ones place, we have: **[329, 543, 765, 986, 217]**.
3. Next, we move to the tens place and perform counting sort again. After sorting based on the tens place, we have: **[329, 543, 217, 765, 986]**.
4. Finally, we sort based on the hundreds place. Since all numbers in our example have the same hundreds digit, the list remains unchanged.
5. The resulting sorted list is **[329, 543, 217, 765, 986]**.

## Complexity Analysis

Radix sort has a time complexity of O(nk), where n is the number of elements in the list and k is the number of digits in the largest number. This makes Radix sort efficient for sorting large sets of numbers. However, it may require additional memory space for the counting arrays used in the sorting process.

## Code Examples

To further illustrate the Radix sort algorithm, we have provided code examples in three different programming languages: Python, C++, and C#. You can find the code samples in the respective folders in this repository. Each code example demonstrates how to implement Radix sort to sort a list of numbers, including handling both positive and negative numbers.

Feel free to explore the code examples, run them, and modify them to gain a deeper understanding of how Radix sort works.

## Conclusion

Congratulations! You now have a basic understanding of the Radix sort algorithm. We hope this README has provided you with a clear explanation of the algorithm's steps, examples, and complexity analysis. Code implementation in Python, C++, and C# can be found here:
- [Radix Sort Python code implementation](https://github.com/georgeuwagbale/algorithms/edit/main/Radix_Sort_Algorithm/src/RadixSort.py)
- [Radix Sort C++ code implementation](https://github.com/georgeuwagbale/algorithms/edit/main/Radix_Sort_Algorithm/src/RadixSort.cpp)
- [Radix Sort C# code implementation](https://github.com/georgeuwagbale/algorithms/edit/main/Radix_Sort_Algorithm/src/RadixSort.cs)

Feel free to explore further, experiment with different scenarios, and apply Radix sort to sort various lists of numbers.

If you have any questions or need further clarification, don't hesitate to reach out. Happy sorting!

## Resources

For additional resources and further learning, consider the following:

- [Wikipedia - Radix Sort](https://en.wikipedia.org/wiki/Radix_sort)
- [GeeksforGeeks - Radix Sort](https://www.geeksforgeeks.org/radix-sort/)
- [YouTube - Radix Sort Explained](https://www.youtube.com/watch?v=nu4gDuFabIM)

These resources provide more in-depth explanations, visualizations, and alternative implementations of the Radix sort algorithm.
