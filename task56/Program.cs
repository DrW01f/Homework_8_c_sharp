// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

int[] InputParametrs()
{   
    int[] parametrs = new int[2];
    while (true)
    {
        Console.WriteLine("Введите количество строк");
        int row = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите количество столбцов (не должно равняться количеству строк)");
        int column = int.Parse(Console.ReadLine()!);
        if (row != column) 
        {
            parametrs[0] = row;
            parametrs[1] = column;
            return parametrs;
        }            
    }    
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

int FindMinSum(int[,] array)
{
    int minSumLine = 0;
    int sumFirst = 0;
    int sumLast = 0;

    for (int i = 0, k = i +1; i < array.GetLength(0) - 1 && k < array.GetLength(0); i++, k++)
    //прохожу сразу по двум соседним строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumFirst += array[i,j];
            sumLast += array[k,j];
        }
        if (sumFirst < sumLast) minSumLine = i + 1; // номер строки, а не индекс
        sumFirst = 0;
        sumLast = 0;

    }
    return minSumLine;
}

void Main()
{
    Console.Clear();
    int[] rowAndColumn = InputParametrs();
    int[,] array = GetArray(rowAndColumn);
    PrintArray(array);
    int result = FindMinSum(array);
    Console.WriteLine($"Строка номер {result} имеет минимальную сумму элементов");

}

Main();