// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void SortArr(int[,] arr)
{
    int [] resMas= new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            resMas[j]=arr[i,j];
        }
        Array.Sort(resMas);
        Array.Reverse(resMas);
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(resMas[j]+"  ");
        }
        Console.WriteLine();
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");

        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(4, 4, 0, 10);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SortArr(array);