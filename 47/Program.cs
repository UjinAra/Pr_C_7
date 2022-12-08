// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}

double [,] GetArray(int m, int n, int minVal, int maxVal)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //double r = Convert.ToDouble(x.Next(-100, 100)/10.0);
        result[i,j] =  Convert.ToDouble(new Random().Next(minVal,maxVal)/10.0);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= -100; //ReadFromConsole("Начальное число диапазон"); 
int maxVal= 100; //ReadFromConsole("Конечное число диапазон"); 
double[,] array = GetArray(row,colm,minVal,maxVal);
PrintArray(array);

