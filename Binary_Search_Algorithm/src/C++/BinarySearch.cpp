#include <iostream>
#include <vector>
#include <string>

using namespace std;

string binarySearch(const vector<int>& arr, int value) {
    int lowerBound = 0;
    int upperBound = arr.size() - 1;

    while (lowerBound <= upperBound) {
        int midpoint = (upperBound + lowerBound) / 2;
        int valueAtMidpoint = arr[midpoint];

        if (value == valueAtMidpoint) {
            return to_string(value) + " exists in the given array and its index is " + to_string(midpoint) + ".";
        }
        else if (value > valueAtMidpoint) {
            lowerBound = midpoint + 1;
        }
        else if (value < valueAtMidpoint) {
            upperBound = midpoint - 1;
        }
    }

    return to_string(value) + " does not exist in the given array.";
}

int main() {
    int user_input;
    vector<int> arr = { 0, 3, 4, 5, 6 };
    cout << "Input the value you want to search for: ";
    cin >> user_input;

    cout << binarySearch(arr, user_input) << endl;

    return 0;
}
