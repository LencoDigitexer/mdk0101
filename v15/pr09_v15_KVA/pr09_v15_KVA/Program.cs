using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr09_v15_KVA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать экземпляр класса:
            Rectangle X = new Rectangle(); // с длинами сторон "по умолчанию", равными 1 и 1;
            Rectangle Y = new Rectangle(5, 10); // с заданными длинами сторон.

            Console.WriteLine("Длины сторон прямоугольников: ");
            X.Display();
            Y.Display();

            Console.Write("\nПериметр прямоугольников: \n");
            Console.WriteLine(X.Perimetr());
            Console.WriteLine(Y.Perimetr());

            Console.Write("\nПлощадь прямоугольников: \n");
            Console.WriteLine(X.Ploshad());
            Console.WriteLine(Y.Ploshad());

            Console.WriteLine("\nПолучить-установить длины сторон прямоугольников (доступное для чтения и записи):");
            X.A = 4; //Изменение переметров через свойства
            X.B = 4;
            X.Display();

            Y.A = 20;//Изменение переметров через свойства
            Y.B = 50;
            Y.Display();

            Console.WriteLine("\nЯвляется ли данный прямоугольник квадратом(только для чтения):");
            Console.WriteLine(X.isSquare);
            Console.WriteLine(Y.isSquare);

            Console.ReadKey();
        }
    }
}
class Rectangle
{   // поля - приватные
    private int a; // сторона а
    private int b; // сторона b

    public Rectangle()      // конструктор - значения по умолчанию
    {
        this.a = 1;
        this.b = 1;
    }

    public Rectangle(int a, int b) // для определения приватных переменных через создание класса
    {
        this.a = a;
        this.b = b;
    }

    // методы
    public void Display()   // вывести длины сторон прямоугольника на экран;
    {
        Console.WriteLine("Стороны a, b: {0} {1}", a, b);
    }

    public double Perimetr() //расчитать периметр прямоугольника
    {
        return 2 *(a + b);
    }

    public double Ploshad() //расчитать площадь прямоугольника.
    {
        return a * b;
    }

    

    // свойства - позволяющие получить-установить длины сторон прямоугольника (доступное для чтения и записи);
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


    public string isSquare // существует ли треугольник с данными длинами сторон (доступное только для чтения).
    {
        get
        {
            // Если две стороны меньше третей, то существует
            if (a == b) return "Это квадрат";
            return "Это не квадрат";
        }
    }



}
