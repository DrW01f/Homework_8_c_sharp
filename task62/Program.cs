// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

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

int[,] GetArray(int[] array)
{
    int[,] result = new int[array[0], array[1]];
    int i = 1;
    int row = 0;
    int column = 0;

    while (i <= array[0] * array[1])
    {
        result[row, column] = i;  
        i++;
        if ((row <= column + 1) && (row + column < array[1] - 1))
            column++;
        else if ((row < column) && (row + column >= array[0] - 1))
            row++;
        else if ((row >= column) && (row + column > array[1] - 1))
            column -=  1;
        else
            row -= 1;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        if (inArray[i, j] / 10 <= 0) Console.Write($"{0}{inArray[i, j]}\t ");
        else Console.Write($"{inArray[i, j]}\t ");               
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Main()
{
    Console.Clear();
    int[] parametrs = InputParametrs();
    int[,] array = GetArray(parametrs);
    PrintArray(array);    

}

Main();

