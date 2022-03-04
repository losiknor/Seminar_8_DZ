// Задача 57: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] array = new int[new Random().Next(3, 10), new Random().Next(3, 10)];
Console.WriteLine("Задан двумерный массив:");
Console.WriteLine($"Строк {array.GetLength(0)}; столбцов {array.GetLength(1)}");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10, 99);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");
Console.WriteLine("Тот же массив с упорядоченными по убыванию элементами каждой строки:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, k] < array[i, j])
            {
                array[i, j] = array[i, j] + array[i, k];
                array[i, k] = array[i, j] - array[i, k];
                array[i, j] = array[i, j] - array[i, k];
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    Console.WriteLine("");
}