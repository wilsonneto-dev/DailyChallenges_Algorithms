def solution(numbers, target_sum):
    for index in range(len(numbers)):
        indexToSum = index +1;

        for indexToSum in range(index + 1, len(numbers)):
            if (numbers[index] + numbers[indexToSum] == target_sum):
                return [numbers[index], numbers[indexToSum]]

    return []
