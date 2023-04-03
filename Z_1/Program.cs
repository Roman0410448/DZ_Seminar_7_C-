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

PrintMatrix(array2D);  // inputMatrix = array2D
// Console.WriteLine("Вывод матрицы  2 на 2 для теста: ");
// PrintMatrix(testMatrix); // inputMatrix = testMatrix
// Console.WriteLine("Вывод матрицы  3 на 3 для теста: ");
// PrintMatrix(secondTestMatrix); // inputMatrix = secondTestMatrix
// Печатаем двумерный массив на экран
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
