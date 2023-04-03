// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

 Console.Write("Введите координаты элемента массива (в формате i,j): ");
    string posInput = Console.ReadLine();
    string[] pos = posInput.Split(',');
    int i = Convert.ToInt32(pos[0]);
    int j = Convert.ToInt32(pos[1]);
    CoordinatesMatrix(array2D);
void CoordinatesMatrix(int[,] Coordinates)
{
    if (i < 0 || i >= Coordinates.GetLength(0) || j < 0 || j >= Coordinates.GetLength(1)) {
        Console.WriteLine("Ошибка: заданные координаты находятся за пределами массива");
    } else { 
        Console.Write("Элемент на заданных координатах:  " + Coordinates[i, j]);
    }
}
  