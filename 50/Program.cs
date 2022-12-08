// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void PrintChislo(int[,] inArray, int chislo)
{
    string coorbChislo = string.Empty ;
    bool fistchislo = false;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j]== chislo && fistchislo ==false)
            {
                coorbChislo = "Строка - " + (i+1) + ", Столбец - "+(j+1);
                fistchislo = true;
            }
        }    
    }
    if (fistchislo == true) 
        {
         Console.WriteLine(coorbChislo);
        }
    else Console.WriteLine("Числа нет в массиве");
} 

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= ReadFromConsole("Начальное число диапазон"); 
int maxVal= ReadFromConsole("Конечное число диапазон"); 
int chislo= ReadFromConsole("Найти число в массиве"); 
int[,] array = GetArray(row,colm,minVal,maxVal);
PrintArray(array);
PrintChislo(array, chislo);