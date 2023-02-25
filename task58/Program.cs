// Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:


int[] InputParametrs()
{
    int[] parametrs = new int[2];
    Console.Write("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);
    parametrs[0] = row;
    parametrs[1] = column;
    return parametrs;
}

int[,] GetArray(int[] array, int minValue = 1, int maxValue = 10)
{
    int[,] result = new int[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

bool Validation(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    // for (int i = 0; i < matrix1.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix2.GetLength(1); j++)
    //     {
    //         resultMatrix[i,j] = matrix1[i,j] * matrix2[i,j] + matrix1[i,j + 1] * matrix2[i + 1,j];
    //     }
    // }
    return resultMatrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Main()
{
    Console.Clear();
    Console.WriteLine("Для перемножения матриц кол-во столбцов первой должно быть равно кол-ву строк второй");
    int[] parametrsFirstMatrix = InputParametrs();
    int[,] matrix1 = GetArray(parametrsFirstMatrix);
    PrintArray(matrix1);

    int[] parametrsSecondMatrix = InputParametrs();
    int[,] matrix2 = GetArray(parametrsSecondMatrix);
    PrintArray(matrix2);
  
    if (Validation(matrix1, matrix2))
    {
        int[,] result = MatrixMultiplication(matrix1, matrix2);
        PrintArray(result);
    }
    else Console.WriteLine("Перемножить матрицы невозможно");


}

Main();