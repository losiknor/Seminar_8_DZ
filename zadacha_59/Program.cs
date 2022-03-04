// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] array = new int[new Random().Next(3, 10), new Random().Next(3, 10)];
Console.WriteLine("Задана прямоугольная матрица:");
Console.WriteLine($"Строк {array.GetLength(0)}; столбцов {array.GetLength(1)}");
int[] arraySum = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    arraySum[i] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10, 99);
        Console.Write(array[i, j] + " ");
        arraySum[i] = arraySum[i] + array[i, j];
    }
    Console.Write($"  Сумма строки:  {arraySum[i]}");
    Console.WriteLine("");
}
Console.WriteLine("");
int minSum = arraySum[0];
int indexMin = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (arraySum[i] < minSum)
    {
        minSum = arraySum[i];
        indexMin = i;
    }
}
Console.Write("Строка с наименьшей суммой элементов: ");
for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[indexMin, j] + " ");
