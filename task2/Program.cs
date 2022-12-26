/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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

void PrintArray(int[,] matrix)
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

void GetElement(int[,] matrix, int index)
{
    // + 1 - для перехода к системе индексов, понятной пользователю
    if (index/10 > matrix.GetLength(0) || index%10 > matrix.GetLength(1)) 
    {
        Console.WriteLine("В массиве нет элемента с таким индексом");
    }
    else
    {
        Console.WriteLine($"Элемент массива с индексом {index}: {matrix[index/10 - 1,index%10 - 1]}");
    }
}
   
    

int m = GetNumber("Введите количество строк в массиве");
int n = GetNumber("Введите количество столбцов в массиве");
int[,] matr = InitMatrix(m,n);
PrintArray(matr);
int indexOfElement = GetNumber("Введите индекс элемента");
GetElement(matr, indexOfElement);


