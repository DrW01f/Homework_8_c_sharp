// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Буду считать, что k (первый индекс в массиве) - глубина, i (второй) строка, j (третий) столбец

int[] InputParametrs()
{
    int[] parametrs = new int[3];
    Console.Write("Введите количество слоев: ");
    int depths = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int column = int.Parse(Console.ReadLine()!);

    parametrs[0] = depths;
    parametrs[1] = row;    
    parametrs[2] = column;
    return parametrs;
}

int[,,] GetArray(int[] array, int minValue = 10, int maxValue = 99)
{
    int[,,] result = new int[array[0], array[1], array[2]];
    int[] dictionary = {};
    // int temp = 0;
    // int condition = 0;
    // int end = 0;
    int m = minValue;
    for(int k = 0; k < array[0]; k++)
    {
        for (int i = 0; i < array[1]; i++)
        {
            for (int j = 0; j < array[2]; j++)
            {
                result[k, i, j] += minValue;
                minValue++;
                
                // while (true)
                // {
                //     temp = new Random().Next(minValue, maxValue + 1);
                //     condition = Array.IndexOf(dictionary, temp);
                //     if (condition == -1)                    
                //     {
                //         result[k, i, j] = temp;
                //         dictionary.Append(temp);                        
                //         j++;
                //         end++;                      
                //         break;
                //     }
                // }                             
            }
        }
    }    
    return result;
}

void PrintArray(int[,,] inArray)
{
    for(int k = 0; k < inArray.GetLength(0); k++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = 0; j < inArray.GetLength(2); j++)
            {
                Console.Write($"{inArray[k, i, j]}({k},{i},{j})\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();
    int[] parametrsTesseract = InputParametrs();
    int[,,] tesseract = GetArray(parametrsTesseract);
    PrintArray(tesseract);
}

Main();


