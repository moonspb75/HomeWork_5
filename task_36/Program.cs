// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на чётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-9, 100);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
int sumNumber = 0;
System.Console.WriteLine($"[{string.Join(", ", array)}]");

for(int i = 1; i < array.Length; i+=2)
{
    sumNumber += array[i];
}

System.Console.WriteLine($"Сумма стоящая на четных позициях = {sumNumber} ");