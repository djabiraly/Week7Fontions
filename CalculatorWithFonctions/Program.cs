
int a = 8;
int b = 5;


Add(a, b);
Add(10, 100);
Add(56583, 658686);

Mutiply(a, b);
Mutiply(10, 100);

Divide(a, b);
Divide(10, 100);

Substract(a, b);
Substract(10, 100);


static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}
static void Mutiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}


static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}
static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}