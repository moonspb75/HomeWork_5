// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int size = new Random().Next(1, 30);
System.Console.WriteLine($"Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine($"[{string.Join(", ", size)}]");
// System.Console.WriteLine($"массив: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение массива: [{string.Join(", ", arr.Min())}]");
    System.Console.WriteLine($"максимальное значение массива: [{string.Join(", ", arr.Max())}]");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(size));
System.Console.WriteLine();