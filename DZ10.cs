Console.Write("Введите проверяемое число: ");
int current = int.Parse(Console.ReadLine());

if (current < 100)
{
Console.Write("Число отсутствует");
}
if (100 <= current && current < 1000)
{
int a1 = current % 10;
Console.Write(a1);
}
if (1000 <= current && current < 10000)
{
int a1 = (current / 10) % 10;
Console.Write(a1);
}
if (10000 <= current && current < 100000)
{
int a1 = (current / 100) % 10;
Console.Write(a1);
}
if (100000 <= current && current < 1000000)
{
int a1 = (current / 1000) % 10;
Console.Write(a1);
}
if (1000000 <= current && current < 10000000)
{
int a1 = (current / 10000) % 10;
Console.Write(a1);
}
if (10000000 <= current && current < 100000000)
{
int a1 = (current / 100000) % 10;
Console.Write(a1);
}
if (100000000 <= current && current < 1000000000)
{
int a1 = (current / 1000000) % 10;
Console.Write(a1);
}
if (1000000000 <= current && current < 1000000000)
{
int a1 = (current / 10000000) % 10;
Console.Write(a1);
}