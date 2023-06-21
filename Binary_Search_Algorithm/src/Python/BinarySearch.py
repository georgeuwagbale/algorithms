def binary_search(array: list, value: int) -> str:
    # First, we establish the lower and upper bounds of where the value
    # we're searching for can be. To start, the lower bound is the first
    # value in the array, while the upper bound is the last value:
    lower_bound = 0
    upper_bound = len(array) - 1

    # We begin a loop in which we keep inspecting the middlemost value
    # between the upper and lower bounds:
    while lower_bound <= upper_bound:
        # We find the midpoint between the upper and lower bounds:
        midpoint = (upper_bound + lower_bound) // 2
        # We inspect the value at the midpoint:
        value_at_midpoint = array[midpoint]
        # If the value at the midpoint is the one we're looking for, we're done.
        # If not, we change the lower or upper bound based on whether we need
        # to guess higher or lower:
        if value == value_at_midpoint:
            return f'{value} exists in the given array and its index is {midpoint}.'
        if value > value_at_midpoint:
            lower_bound = midpoint + 1
        if value < value_at_midpoint:
            upper_bound = midpoint - 1

    return f'{value} does not exist in the given array.'


print(binary_search([ 0, 3, 4, 5, 6], 0))
