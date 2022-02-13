using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.
/// Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
/// </summary>
namespace Task3
{
    class Program
    {
        static void Main()
        {
            int rows = 3, columns = 3;

            MyMatrix myMatrix = new MyMatrix(rows, columns);
            myMatrix.Show();
            Console.WriteLine("");
            myMatrix.ShowDerivative(1);
            Console.ReadKey();
        }
    }
    class MyMatrix
    {
        int[,] matrix;
        Random rnd = new Random();
        public void Show()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],-4}");
                }
                Console.WriteLine("");
            }
        }
        public void ShowDerivative(int order)
        {
            if (matrix.GetLength(0) - order > 0 & matrix.GetLength(1) - order > 0)
            {
                for (int i = 0; i < matrix.GetLength(0) - order; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - order; j++)
                    {
                        Console.Write($"{matrix[i, j],-4}");
                    }
                    Console.WriteLine("");
                }
            }
            else Console.WriteLine("Невозможно отобразить производную матрицу");
        }
        public MyMatrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }
    }
}
