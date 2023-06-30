using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine()!);

Write("Введите строку элемента: ");
int strok =int.Parse(ReadLine()!);

Write("Введите столбец элемента: ");
int stolb =int.Parse(ReadLine()!);



int[,] array = GetArray(rows, columns, 0, 10);


PrintArray(array);

WriteLine();

FindElement(array,strok,stolb);

int[,] GetArray(int m, int n, int minValue, int maxValue)
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
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void FindElement(int[,] inArray,int a,int b)
{
if (a>inArray.GetLength(0) || b>inArray.GetLength(1)) {
    Write("такого числа в массиве нет");
    
}
else Write (inArray[a-1,b-1]);
}