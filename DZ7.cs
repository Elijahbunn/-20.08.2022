Random rnd = new Random();
int number = rnd.Next(10, 99);
Console.WriteLine(number);

int a1 = number / 10;
int b1 = number % 10;
if (a1 > b1)
{
    Console.WriteLine(a1);
}
else if (a1 < b1)
{
    Console.WriteLine(b1);
}