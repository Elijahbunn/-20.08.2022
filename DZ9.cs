Console.Write("Введите проверяемое число: ");
int current = int.Parse(Console.ReadLine());
Console.Write("Введите делитель: ");
int del = int.Parse(Console.ReadLine());

int kiss = current % del;

if (kiss == 0)
{
Console.Write("Проверяемое число кратно заданному.");
}

else if (kiss != 0)
{
Console.Write("Остаток равен: " + kiss);
}