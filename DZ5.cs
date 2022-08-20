// int[] numbers = {1..15};
// int size = 16;
// int index = 0;
// int d = numbers[index] % 2;

int N = 15;
int current = 1;
int d = current % 2;

while (current <= N)
{
    if (d == 0)
    {
        Console.WriteLine (" " + current);
    }
    current = current + 1;
}
