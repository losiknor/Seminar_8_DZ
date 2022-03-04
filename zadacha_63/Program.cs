// Задача 63: Сформировать трёхмерный массив с неповторяющимися 
// двузначными числами и вывести его на экран построчно, с индексами элементов.
int[,,] array3D = new int[5, 4, 4];
int valueToFill = 9;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        for (int k = 0; k < 4; k++)
        {
            array3D[i,j,k] = valueToFill + 1;
            valueToFill++;
            Console.Write($"элемент[{i},{j},{k}]{array3D[i,j,k]}  ");
        }
    Console.WriteLine("");
    }
Console.WriteLine("");
Console.WriteLine("");
}
