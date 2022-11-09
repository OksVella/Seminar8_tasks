// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = 5;
int columns = 3;
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
int rowNumber = GetRowNumber(matrix, rows);
Console.WriteLine("Row # = " + rowNumber);


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetArrayWithSums(int[,] matr, int rows)
{
    int[] array = new int[rows];
    for (int count = 0; count < rows; count++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[count, j];
        }
        array[count] = sum;
    }

    return array;
}

int GetRowNumber(int[,] matr, int rows)
{
    int[] array = GetArrayWithSums(matr, rows);

    int min = array[0];
    int index = 0;
    Console.Write(array[0] + ", ");

    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine();
    return index + 1;
}

