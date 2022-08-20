Console.WriteLine("Введите число:");
double x = double.Parse(Console.ReadLine());
double d = x % 2;

if (d == 0)
{
    Console.WriteLine("Число четное");
}

else if (d != 0)
{
    Console.WriteLine("Число нечетное");
}