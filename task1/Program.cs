/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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


double[,] InitMatrix (int m, int n)
{
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int diapazon = rnd.Next(-10,10);
            while (diapazon == 0)
                diapazon = rnd.Next(-10,10);
            matrix[i,j] = Math.Round(rnd.NextDouble() * diapazon * 100, 1);  
        }
        
    }
    return matrix;
}

void PrintArray(double[,] matrix)
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
    

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
double[,] matr = InitMatrix(m,n);
PrintArray(matr);



