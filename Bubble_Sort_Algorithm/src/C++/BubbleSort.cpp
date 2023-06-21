#include <iostream>
#include <vector>

using namespace std;

void bubbleSort(vector<int>& arr) {
    int unsortedUntilIndex = arr.size() - 1;
    bool sorted = false;
    while (!sorted) {
        sorted = true;
        for (int i = 0; i < unsortedUntilIndex; i++) {
            if (arr[i] > arr[i + 1]) {
                sorted = false;
                swap(arr[i], arr[i + 1]);
            }
        }
        unsortedUntilIndex--;
    }
}

int main() {
    vector<int> arr = {65, 55, 45, 35, 25, 15, 10};
    bubbleSort(arr);
    for (int num : arr) {
        cout << num << " ";
    }
    cout << endl;
    return 0;
}
