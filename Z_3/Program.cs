// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = GetMatrix(rows, columns, 0, 10);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // [rows, columns]
    for (int i = 0; i < matrix.GetLength(0); i++) //  matrix.GetLength(0) = m - строчки
    {
        // i, j , m , k
        for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = n - столбцы
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

PrintMatrix(array2D);  // inputMatrix = array2D

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // столбцы
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - отступ между элементами   
        }
        Console.WriteLine(); // Переход на новую строчку
    }
}
  // Нахождение среднего арифметического в каждом столбце
  double[] AverageMatrix(int[,] arr )
  {
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    double[] averageValues = new double[cols];
    for (int j = 0; j <cols; j++)
    {
      double sum = 0;
      for (int i = 0; i < rows; i++)
    {
        sum += arr [i,j];
      }
      averageValues[j] = sum / rows;
      
     }
     return averageValues;
  }
      double [] averageValues = AverageMatrix(array2D);
      Console.WriteLine("Средние арифметические для каждого столбца:");
      for (int i = 0; i < averageValues.Length; i++)
      {
      Console.WriteLine(averageValues[i]);
      }
