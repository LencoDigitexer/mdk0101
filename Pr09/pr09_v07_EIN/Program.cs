// Программа для задания "Треугольники" с элементами ООП
// Вариант 7.
// Autor: Евсеенко Илья
// Group: ИП193

/*
  Создать класс Triangle, разработав следующие элементы класса:
   1)  Поля:
        int a, b, c;
   2) Конструкторы, позволяющие создать экземпляр класса:
        с длинами сторон "по умолчанию", равными 3, 4 и 5;
        с заданными длинами сторон.
   3) Методы, позволяющие:
        вывести длины сторон треугольника на экран;
        расчитать периметр треугольника;
        расчитать площадь треугольника.
   4) Свойства:
        позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);
        позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr09_v07_EIN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать экземпляр класса:
            Triangle X = new Triangle(); // с длинами сторон "по умолчанию", равными 3, 4 и 5;
            Triangle Y = new Triangle(70, 50, 20); // с заданными длинами сторон.

            Console.WriteLine("Длины сторон треугольников: ");
            X.Display();
            Y.Display();

            Console.Write("\nПериметр треугольников: \n");
            Console.WriteLine(X.Perimetr());
            Console.WriteLine(Y.Perimetr());

            Console.Write("\nПлощадь треугольников: \n");
            Console.WriteLine(X.Ploshad());
            Console.WriteLine(Y.Ploshad());

            Console.WriteLine("\nПолучить-установить длины сторон треугольника (доступное для чтения и записи):");
            X.A = 4; //Изменение переметров через свойства
            X.B = 5;
            X.C = 6;
            X.Display();

            Y.A = 20;//Изменение переметров через свойства
            Y.B = 50;
            Y.C = 10;
            Y.Display();

            Console.WriteLine("\nСуществует ли треугольник с данными длинами сторон(только для чтения):");
            Console.WriteLine(X.isTriangle);
            Console.WriteLine(Y.isTriangle);

            Console.ReadKey();

        }
    }
}

class Triangle
{   // поля - приватные
    private int a; // сторона а
    private int b; // сторона b
    private int c; // сторона c

    public Triangle()      // конструктор - значения по умолчанию
    {
        this.a = 3;
        this.b = 4;
        this.c = 5;
    }
    
    public Triangle(int a, int b, int c) // для определения приватных переменных через создание класса
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // методы
    public int Perimetr() // расчитать периметр треугольника;
    {
        return a + b + c;
    }

    public double Ploshad() //расчитать площадь треугольника.
    {
        double PolovinaPerim = (double)(a + b + c) / 2;
        // площадь через корень половин периметра
        return Math.Sqrt(PolovinaPerim * (PolovinaPerim - a) * (PolovinaPerim - b) * (PolovinaPerim - c));
    }

    public void Display()
    {   // вывести длины сторон треугольника на экран;
        Console.WriteLine("Стороны a, b, c: {0} {1} {2}",
                           a, b, c);
    }

    // свойства - позволяющие получить-установить длины сторон треугольника (доступное для чтения и записи);
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int C
    {
        get { return c; }
        set { c = value; }
    }

    public string isTriangle // существует ли треугольник с данными длинами сторон (доступное только для чтения).
    {
        get
        {
            // Если две стороны меньше третей, то существует
            if (a + b > c && a + c > b && b + c > a) return "Существует";
            return "Не существует";
        }
    }

    

}
