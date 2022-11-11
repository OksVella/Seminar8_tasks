// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.
int [,,] matrix3d = new int[2,2,2];
FillArray(matrix3d);
PrintArray(matrix3d);




void FillArray(int [,,] matrix3d)
{
  int[] temp = new int[matrix3d.GetLength(0) * matrix3d.GetLength(1) * matrix3d.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3d.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3d.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3d.GetLength(2); z++)
      {
        matrix3d[x, y, z] = temp[count];
        count++;
      }
    }
  }
}



void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k=0; k<matrix3d.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}");
                Console.Write("(" + i + "," + j + "," + k +") ");
            }
        }
        Console.WriteLine();
    }
}
