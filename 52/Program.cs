// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}

int [,] GetArray(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //double r = Convert.ToDouble(x.Next(-100, 100)/10.0);
        result[i,j] =  new Random().Next(minVal,maxVal);
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
            Console.Write($" \t{inArray[i,j]} ");
        }    
        Console.WriteLine();
    }
} 

void PrintArifChislo(int[,] inArray)
{
    double chislo = 0;
    Console.Write ("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
            {
            chislo = chislo + inArray[j,i];
            }     
    Console.Write($"{Math.Round((chislo/inArray.GetLength(1)),2)}  ");
    chislo = 0;
    }
    Console.WriteLine();
} 

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= ReadFromConsole("Начальное число диапазон"); 
int maxVal= ReadFromConsole("Конечное число диапазон"); 
int[,] array = GetArray(row,colm,minVal,maxVal);
PrintArray(array);
PrintArifChislo(array);