using System;
using System.Linq;
/// <summary>
/// Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
/// Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main()
        {
            int N = 5;
            int[] ints = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                ints[i] = random.Next();
            }
            Console.WriteLine(ints.Max());

            Console.ReadKey();
        }
    }
}
