using System;

// 1

Func<int> getNumber = () => 1234;
Console.WriteLine(getNumber());

Func<int, int> square = x => x * x;
Console.WriteLine(square(3));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 5));

// 2

Action sayHello = () => Console.WriteLine("안녕하세요!");
sayHello();

Action<string> print = message => Console.WriteLine(message);
print("Hello, Lambda!");

Action<string, int> repeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
repeat("반복!", 3);

// 3

Func<int, int> anonymous = delegate (int x) { return x * x; };
Console.WriteLine(anonymous(2));

Func<int, int> lambda = x => x * x;
Console.WriteLine(lambda(2));