using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace pr12_13_v07_EIN
{

    //// Абстрактный класс
    public abstract class Client
    {
        public abstract string Show(); // вывод информации на экран
        public abstract string Search(DateTime date); // определить соответствие клиента критерию поиска
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
                   "\r\nДата открытия вклада: " + DepositDate.ToShortDateString() +
                   "\r\nРазмер вклада: " + DepositAmount +
                   "\r\nПроцент по вкладу: " + DepositInterest +
                   "\r\n\r\n";
            
        }

        public override string Search(DateTime date)
        {
            if (DepositDate == date) { return "\n" + this.Show(); }
                else return "";
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
                   "\r\nДата выдачи кредита: " + CreditDate.ToShortDateString() +
                   "\r\nРазмер кредита: " + CreditAmount +
                   "\r\nПроцент по кредиту: " + CreditInterest +
                   "\r\nОстаток долга: " + CreditBalance + "\r\n\r\n";
        }

        public override string Search(DateTime date)
        {
            if (CreditDate == date) { return "\n" + this.Show(); }
            else return "";
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
                   "\r\nnДата открытия счета: " + AccountDate.ToShortDateString() +
                   "\r\nНомер счета: " + AccountNumber +
                   "\r\nСумма на счету: " + AccountAmount + "\r\n\r\n";
        }

        public override string Search(DateTime date)
        {
            if (AccountDate == date) { return "\n" + this.Show(); }
            else return "";

        }
    }

    
}
