def get_maximum_value(arr):
    maximum = arr[0]
    for i in range(1, len(arr)):
        if arr[i] > maximum:
            maximum = arr[i]
    return maximum


def counting_sort_positive(arr, exp):
    count_array = [0] * 10
    for num in arr:
        count_array[(num // exp) % 10] += 1
    for i in range(1, 10):
        count_array[i] += count_array[i - 1]
    output = [0] * len(arr)
    for i in range(len(arr) - 1, -1, -1):
        current = arr[i]
        position_in_array = count_array[(current // exp) % 10] - 1
        output[position_in_array] = current
        count_array[(current // exp) % 10] -= 1
    for i in range(len(arr)):
        arr[i] = output[i]


def counting_sort_negative(arr, exp):
    count_array = [0] * 10
    for num in arr:
        count_array[9 - ((-num // exp) % 10)] += 1
    for i in range(1, 10):
        count_array[i] += count_array[i - 1]
    output = [0] * len(arr)
    for i in range(len(arr) - 1, -1, -1):
        current = arr[i]
        position_in_array = count_array[9 - ((-current // exp) % 10)] - 1
        output[position_in_array] = current
        count_array[9 - ((-current // exp) % 10)] -= 1
    for i in range(len(arr)):
        arr[i] = output[i]


def radix_sort(arr):
    positive = []
    negative = []
    for num in arr:
        if num >= 0:
            positive.append(num)
        else:
            negative.append(num)

    if positive:
        max_value_positive = get_maximum_value(positive)
        exp = 1
        while max_value_positive // exp > 0:
            counting_sort_positive(positive, exp)
            exp *= 10

    if negative:
        max_value_negative = get_maximum_value(negative)
        exp = 1
        while max_value_negative // exp > 0:
            counting_sort_negative(negative, exp)
            exp *= 10

    pos_index = len(positive) - 1
    neg_index = 0
    for i in range(len(arr)):
        if neg_index < len(negative):
            arr[i] = negative[neg_index]
            neg_index += 1
        else:
            arr[i] = positive[pos_index]
            pos_index -= 1


arr = [1, 0, 4, 5, 7, -3, 9, 2]
radix_sort(arr)
print(arr)
