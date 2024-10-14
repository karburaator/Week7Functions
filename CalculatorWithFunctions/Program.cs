int a = 5;
int b = 6;


Add(a, b);
Add(10, 100);
Add(4321, 1234);

Multiply(a, b);
Multiply(10, 100);
Multiply(4321, 1234);

Substract(a, b);
Substract(10, 100);
Substract(4321, 1234);

Divide(a, b);
Divide(10, 100);
Divide(4321, 1234);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}


static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}