// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

int[,] GetArray(int m, int n, int minValue = 1, int maxValue = 50)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return result;
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
}

void RegularizeArray(int[,] array) 
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j +1; k < array.GetLength(1); k++) // сортировка внутри строки
            {
                if(array[i,j] < array[i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }            
        }
    }
}

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк");
    int row = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите количество столбцов");
    int column = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(row,column);
    PrintArray(array);
    RegularizeArray(array);
    Console.WriteLine();
    PrintArray(array);
 
}

Main();
