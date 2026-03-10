using System;
using System.Collections.Generic;

// 1

var multiplesOf3 = FindNumbers(n => n % 3 == 0);
Console.WriteLine("3의 배수:");
foreach (var n in multiplesOf3)
{
    Console.Write($"{n}");
}
Console.WriteLine();

var perfectSquares = FindNumbers(n =>
{
    int sqrt = (int)Math.Sqrt(n);
    return sqrt * sqrt == n;
});
Console.WriteLine("제곱수:");
foreach (var n in perfectSquares)
{
    Console.Write($"{n}");
}

static List<int> FindNumbers(Predicate<int> predicate)
{
    List<int> result = new List<int>();
    for (int i = 1; i <= 100; i++)
    {
        if (predicate(i))
        {
            result.Add(i);
        }
    }
    return result;
}

// 2