Random rnd = new Random();
int number = rnd.Next(100, 999);
Console.WriteLine(number);

int number2 = (number/10)%10;
Console.Write(number2); 