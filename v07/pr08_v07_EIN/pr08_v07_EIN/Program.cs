using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication5
{
    class pr08_v07_EIN
    {
        static void Main(string[] args)
        {
            int proiz = 1;
            int sum = 0;

            int[] mas = new int[40];
            Random r = new Random();
            Console.WriteLine("Список массива:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(-100, 101);
                Console.Write(mas[i] + " ");
                if (mas[i] % 2 == 0) // если четное
                {
                    sum = sum + mas[i];
                }
                else
                {
                    proiz = proiz * mas[i];
                }

            }

            if (proiz == 1)
            {
                Console.WriteLine("\nНечетных элементов нет");
            }
            else
            {
                Console.WriteLine("\nПроизведение нечетных элементов (кол-во) " + proiz);
            }

            if (sum == 0)
            {
                Console.WriteLine("Чётных элементов нет");
            }
            else
            {
                Console.WriteLine("Сумма чётных элементов " + sum);
            }
            Console.Read();
        }
    }
}