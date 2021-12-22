using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr08_v15_KVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float sum = 0;
            int proiz = 1;
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[n];
            Random r = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-100, 101);
                Console.Write(mas[i] + " ");
                sum = sum + mas[i];
            }
            Console.WriteLine("\nСреднее арифметическое " + (sum / n));
            Console.WriteLine("\nЭлементы, значение которых меньше среднего арифметического:\n");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < (sum / n))
                {
                    Console.Write(mas[i] + " ");
                }
            }
            Console.Read();
        }

    }
}
