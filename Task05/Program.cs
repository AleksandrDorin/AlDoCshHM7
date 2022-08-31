// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

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
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void ChangeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int n = InputNumbers("Введите количество строк массива: ");
int m = InputNumbers("Введите количество столбцов массива: ");
if (n != m)
{
    Console.WriteLine($"Матрица не квадратная! Введите другие значения.");
    Environment.Exit(0);
}

int[,] matrix = new int[n, m];
Console.WriteLine("Исходный массив: ");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("");
Console.WriteLine("Измененный массив: ");
ChangeMatrix(matrix);
PrintMatrix(matrix);