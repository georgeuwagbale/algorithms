#include <iostream>
#include <vector>

using namespace std;

int get_maximum_value(int arr[], int arr_length) {
    int max = arr[0];
    for (int i = 1; i < arr_length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}

void counting_sort_positive(int arr[], int exp, int length) {
    int i, countArray[10] = {0};
    for (i = 0; i < length; i++) {
        countArray[(arr[i] / exp) % 10]++;
    }
    for (i = 1; i < 10; i++) {
        countArray[i] += countArray[i - 1];
    }
    int output[length];
    for (i = length - 1; i >= 0; i--) {
        int current = arr[i];
        int position_in_array = countArray[(current / exp) % 10] - 1;
        output[position_in_array] = current;
        countArray[(current / exp) % 10]--;
    }
    for (i = 0; i < length; i++) {
        arr[i] = output[i];
    }
}

void counting_sort_negative(int arr[], int exp, int length) {
    int i, countArray[10] = {0};
    for (i = 0; i < length; i++) {
        countArray[9 - ((-arr[i] / exp) % 10)]++;
    }
    for (i = 1; i < 10; i++) {
        countArray[i] += countArray[i - 1];
    }
    int output[length];
    for (i = length - 1; i >= 0; i--) {
        int current = arr[i];
        int position_in_array = countArray[9 - ((-current / exp) % 10)] - 1;
        output[position_in_array] = current;
        countArray[9 - ((-current / exp) % 10)]--;
    }
    for (i = 0; i < length; i++) {
        arr[i] = output[i];
    }
}

void radix_sort(int arr[], int length) {
    vector<int> positive, negative;
    for (int i = 0; i < length; i++) {
        if (arr[i] >= 0) {
            positive.push_back(arr[i]);
        } else {
            negative.push_back(arr[i]);
        }
    }

    if (!positive.empty()) {
        int max_value_positive = get_maximum_value(&positive[0], positive.size());
        for (int exp = 1; max_value_positive / exp > 0; exp *= 10) {
            counting_sort_positive(&positive[0], exp, positive.size());
        }
    }

    if (!negative.empty()) {
        int max_value_negative = get_maximum_value(&negative[0], negative.size());
        for (int exp = 1; max_value_negative / exp > 0; exp *= 10) {
            counting_sort_negative(&negative[0], exp, negative.size());
        }
    }

    int pos_index = positive.size() - 1;
    int neg_index = 0;
    for (int i = 0; i < length; i++) {
        if (neg_index < negative.size()) {
            arr[i] = negative[neg_index];
            neg_index++;
        } else {
            arr[i] = positive[pos_index];
            pos_index--;
        }
    }
}

int main() {
    int arr[] = {1, 0, 4, 5, 7, -3, 9, 2};
    int length = sizeof(arr) / sizeof(int);
    radix_sort(arr, length);
    cout << "[";
    for (int i = 0; i < length - 1; i++) {
        cout << arr[i] << ",";
    }
    cout << arr[length - 1] << "]" << endl;
    return 0;
}
