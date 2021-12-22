using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr07_v15_KVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[3];
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                
                Console.WriteLine("Цена {0}-ого товара ", i+1);
                n[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + n[i];
            }
            if (sum > 2000)
            {
                sum = sum - ((sum / 100) * 3);
            }
            Console.WriteLine("Итоговая стоимость = " + sum);

            
        }
    }
}
