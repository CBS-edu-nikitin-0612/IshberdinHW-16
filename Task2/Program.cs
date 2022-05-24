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
            Console.WriteLine("Числа:");
            for (int i = 0; i < N; i++)
            {
                ints[i] = random.Next(0, 100);
                Console.WriteLine(ints[i]);
            }
            Console.WriteLine("Max: " + ints.Max());
            Console.WriteLine("Min: " + ints.Min());
            Console.WriteLine("Avr: " + ints.Average());
            Console.WriteLine("Нечетный числа:");
            foreach (int num in ints.Where(x => x % 2 == 1))
            {
                Console.WriteLine(num);
            }

            //Delay
            Console.ReadKey();
        }
    }
}
