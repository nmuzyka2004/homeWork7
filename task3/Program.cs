/*  Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetNumber (string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число или некорректное число");
        }
    }
    return result;
}


int[,] InitMatrix (int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(-10,10);  
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [] GetAverage(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           summ = summ + matrix[i,j];                               
        }
        average[j] = summ / matrix.GetLength(0);
        
    }
    return average;  
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

   
int m = GetNumber("Введите количество строк в массиве");
int n = GetNumber("Введите количество столбцов в массиве");
int[,] matr = InitMatrix(m,n);
PrintMatrix(matr);
double[] aver = GetAverage(matr);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(aver);



