Console.WriteLine("Введите переменную х:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную у:");
double y = double.Parse(Console.ReadLine());
if (y * y == x)
{
    Console.WriteLine("х - квадрант числа у");
}

else if (y * y != x)
{
    Console.WriteLine("х - не квадрант числа у");
}

