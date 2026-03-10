using System;

int[] numbers = { 10, 25, 7, 42, 18, 33 };
Console.WriteLine($"배열: " + string.Join(", ", numbers));

int sum = ProcessArray(numbers, arr =>
{
    int total = 0;
    foreach (int n in arr)
    {
        total += n;
    }
    return total;
});
Console.WriteLine($"합계: sum");

int max = ProcessArray(numbers, arr =>
{
    int maxValue = arr[0];
    foreach (int n in arr)
    {
        if (n > maxValue)
            maxValue = n;
    }
    return maxValue;
});
Console.WriteLine($"최댓값: {max}");

int min = ProcessArray(numbers, arr =>
{
    int minValue = arr[0];
    foreach (int n in arr)
    {
        if (n < minValue)
            minValue = n;
    }
    return minValue;
});
Console.WriteLine($"최솟값 {min}");

int evenCount = ProcessArray(numbers, arr =>
{
    int count = 0;
    foreach (int n in arr)
    {
        if (n % 2 == 0)
        count++;

    }
    return count;
});
Console.WriteLine($"짝수 개수: {evenCount}");

static int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}