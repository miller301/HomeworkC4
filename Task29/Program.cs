int[] array = new int[8];
Console.WriteLine("Введите 8 целых чисел по очереди для создания массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array [i]}, ");
}
