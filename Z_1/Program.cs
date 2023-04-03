// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// m - строчки, n - столбцы
double[,] array2D = GetMatrix(rows,columns);
double[,] GetMatrix(int m, int n)
{ // [rows, columns]
double[,] arr = new double[m, n];
   Random rand = new Random();
for (int i = 0; i<m; i++) // matrix.GetLength(0) = m - строчки
{
// i, j , m , k
for (int j = 0; j < n; j++) // matrix.GetLength(1) = n - столбцы
{
    arr[i,j] =rand.NextDouble()*100;
}
}
return arr;
}

PrintMatrix(array2D); 
void PrintMatrix(double[,] inputMatrix)
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
