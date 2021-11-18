// Практическая работа № 10-11
// Создание иерархии классов
// Вариант 7.
// Autor: Евсеенко Илья
// Group: ИП193

/* 
1) Создать абстрактный класс Клиент с методами, позволяющими 
 * вывести на экран информацию о клиентах банка, а также 
 * определить соответствие клиента критерию поиска.
 
2) Создать производные классы: 
 * Вкладчик (фамилия, дата открытия вклада, размер вклада, процент по вкладу), 
 * Кредитор (фамилия, дата выдачи кредита, размер кредита, процент по кредиту, остаток долга), 
 * Организация (название, дата открытия счета, номер счета, сумма на счету) 
 * со своими методами 
 * вывода информации на экран, и 
 * определения соответствия дате (открытия вклада, выдаче кредита, открытия счета).

3) Создать базу (массив) из n клиентов, 
 * вывести полную информацию из базы на экран, а также 
 * организовать поиск клиентов, начавших сотрудничать с банком в заданную дату.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr10_11_v07_EIN
{
    //// Абстрактный класс
    public abstract class Client
    {
        public abstract string Show(); // вывод информации на экран
        public abstract void Search(DateTime date); // определить соответствие клиента критерию поиска
    }


    //// Создать производные классы

    //Вкладчик 
    public class Contributor : Client
    {
        string Surname;         // фамилия
        DateTime DepositDate;   // дата открытия вклада
        decimal DepositAmount;  // размер вклада
        double DepositInterest; // процент по вкладу

        // конструкторы
        public Contributor() // по умолчанию
        {
            this.Surname = "NoSurname";
            this.DepositDate = default(DateTime);
            this.DepositAmount = 0;
            this.DepositInterest = 0;
        }

        public Contributor(string surname, DateTime depositDate, decimal depositAmount, double depositInterest) // с параметрами
        {
            this.Surname = surname;
            this.DepositDate = depositDate;
            this.DepositAmount = depositAmount;
            this.DepositInterest = depositInterest;
        }

        // методы абстрактного класса
        public override string Show()
        {
            return "Фамилия вкладчика: " + Surname +
                   "\nДата открытия вклада: " + DepositDate.ToShortDateString() +
                   "\nРазмер вклада: " + DepositAmount +
                   "\nПроцент по вкладу: " + DepositInterest;
        }

        public override void Search(DateTime date)
        {
            if (DepositDate == date) Console.WriteLine("------------------------\n" + this.Show());
        }
    }


    // Кредитор
    public class Creditor : Client
    {
        string Surname;        // фамилия
        DateTime CreditDate;   // дата выдачи кредита
        decimal CreditAmount;  // размер кредита
        double CreditInterest; // процент по кредиту
        decimal CreditBalance; // остаток долга

        // конструкторы
        public Creditor() // по умолчанию
        {
            this.Surname = "NoSurname";
            this.CreditDate = default(DateTime);
            this.CreditAmount = 0;
            this.CreditInterest = 0;
            this.CreditBalance = 0;
        }

        public Creditor(string surname, DateTime creditDate, decimal creditAmount, double creditInterest, decimal creditBalance) // с параметрами
        {
            this.Surname = surname;
            this.CreditDate = creditDate;
            this.CreditAmount = creditAmount;
            this.CreditInterest = creditInterest;
            this.CreditBalance = creditBalance;
        }

        public override string Show()
        {
            return "Фамилия кредитора: " + Surname +
                   "\nДата выдачи кредита: " + CreditDate.ToShortDateString() +
                   "\nРазмер кредита: " + CreditAmount +
                   "\nПроцент по кредиту: " + CreditInterest +
                   "\nОстаток долга: " + CreditBalance;
        }

        public override void Search(DateTime date)
        {
            if (CreditDate == date) Console.WriteLine("------------------------\n" + this.Show());
        }
    }

    // Организации 
    public class Organization : Client
    {
        string Name;           // название
        DateTime AccountDate;  // дата открытия счета
        int AccountNumber;     // номер счета
        decimal AccountAmount; // сумма на счету

        public Organization(string name, DateTime accountDate, int accountNumber, decimal accountAmount)
        {
            this.Name = name;
            this.AccountDate = accountDate;
            this.AccountNumber = accountNumber;
            this.AccountAmount = accountAmount;
        }

        public override string Show()
        {
            return "Название организации: " + Name + 
                   "\nДата открытия счета: " + AccountDate.ToShortDateString() + 
                   "\nНомер счета: " + AccountNumber + 
                   "\nСумма на счету: " + AccountAmount;
        }

        public override void Search(DateTime date)
        {
            if (AccountDate == date) Console.WriteLine("------------------------\n" + this.Show());
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // создаем базу данных 
            Client[] clientDataBase = new Client[]
                {
                    new Contributor("Петров", new DateTime(2020,5,7), 546312.597m, 20.15),
                    new Contributor("Иванов", new DateTime(2020,5,7), 875621.867m, 18.75),

                    new Creditor("Смирнов", new DateTime(2020, 8, 9), 45542.867m, 18.75, 578.89m),
                    new Creditor("Кузнецов", new DateTime(2021, 7, 19), 98822.867m, 18.75, 578.89m),

                    new Organization("Рога и копыта", DateTime.Now, 123456789, 75932.7834m),
                    new Organization("Ростелеком", new DateTime(2010,3,8), 456456785, 321456.7834m)
                };

            // выводим список всех клиентов
            Console.WriteLine("Список всех клиентов\n------------------------");
            foreach (Client client in clientDataBase)
            {
                Console.WriteLine(client.Show());
                Console.WriteLine("------------------------");
            }

            // запрашиваем дату для поиска
            Console.WriteLine("\n\nПоиск клиентов по дате сотрудничества\n------------------------");
            Console.WriteLine("Введите дату в формате (ГГГГ-MM-ДД) или нажмите Enter: ");
            DateTime db;
            string input = Console.ReadLine();

            // если дата пустая, то
            if (input == null)
            {
                db = Convert.ToDateTime(input);
            }
            else // подставляем значение по умолчанию
            {
                Console.WriteLine("Не распознано - используется дата по умолчанию (2020-05-07)\n");
                db = new DateTime(2020, 5, 7);
            }

            // ищем и выводим список клиентов по заданной дате
            foreach (Client client in clientDataBase)
            {
                client.Search(db);
            }

            Console.ReadLine();
        }
    }
}
