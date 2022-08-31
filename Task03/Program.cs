// Написать программу, которая обменивает элементы первой строки и последней строки

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void ChangeElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[array.GetLength(1) - 1, i];
        array[array.GetLength(1) - 1, i] = array[0, i];
        array[0, i] = tmp;
    }
}


int[,] matrix = new int[4, 4];
Console.WriteLine($"Представлена матрица: ");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("");
ChangeElement(matrix);
Console.WriteLine($"В матрице были заменены элементы первой и последней строки: ");
PrintMatrix(matrix);

