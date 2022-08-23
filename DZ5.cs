Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
int i = 0;

for (i = 0; i < length; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");
}

Console.WriteLine(" ");
Console.WriteLine("Четные числа из массива: ");
int size = length;

int current = 1;
int d = current % 2;

for (i = 0; i < size; i++)
{
    current = array[i];
    d = current % 2;
    if (d == 0)
    {
        current = array[i];
        Console.Write(current + " ");
    }
    current = current + 1;
} 
