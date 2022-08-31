// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] FindeIndexElement(int[,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (value == matrix[i, j])
                return new int[] { i, j };
    return new int[] { -1, -1 };
}
int[,] matrix = new int[3, 3];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("");
Console.WriteLine("Enter element to finde: ");
int findelement = int.Parse(Console.ReadLine() ?? "0");
int[] position = FindeIndexElement(matrix, findelement);
Console.WriteLine(position[0] < 0 || position[1] < 0
    ? "Element not found"
    : $"Position of element: ({position[0]},{position[1]})");