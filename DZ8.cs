Random rnd = new Random();
int number = rnd.Next(100, 999);
Console.WriteLine(number);

int a1 = number / 100;
Console.Write(a1);
int b1 = number % 10;
Console.Write(b1);