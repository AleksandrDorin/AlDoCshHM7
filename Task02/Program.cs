// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
void ArithmeticMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int calculations = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            calculations += matrix[i, j];
        }
        int result = calculations / matrix.GetLength(0);
        Console.Write($"{result}\t");
    }
}
int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("");
ArithmeticMean(matrix);


