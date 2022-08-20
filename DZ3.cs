// Console.WriteLine("Введите первое число:");
// double x = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// double y = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// double z = double.Parse(Console.ReadLine());

int[] numbers = {1, 5, 7, 34, 8, 98, 16};
int size = 7;
int index = 0;
int max = numbers[0];

while (index < size){
    if (numbers[index] > max)
    {
        max = numbers[index];
    }  
    index = index + 1;
}

Console.WriteLine(max);