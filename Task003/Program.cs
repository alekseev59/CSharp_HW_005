// Задайте с клавиатуры массив вещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] => 76

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Получившийся массив : ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1, 100));
    }
}
void PrintArray(double[] numbers)

{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine($"В массиве всего - {numbers.Length} чисел. Максимальный элемент в массиве = {max}, минимальный элемент в массиве = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");