using System;
using System.Collections.Generic;

namespace Laboratory_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 7.1
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("Программа создает класс счета в банке, добавляет туда номер, количество денег на счете и определяет тип счета");
            BankAccount1 bankAccount_1 = new BankAccount1();
            bankAccount_1.AccountNumber = 1234567890;
            bankAccount_1.AccountBalance = 100000.19;
            bankAccount_1.AccountType = BankAccountType.Savings_account;
            Console.WriteLine($"Счет под номером {bankAccount_1.AccountNumber} и типом {bankAccount_1.AccountType} содержит {bankAccount_1.AccountBalance} рублей");
            // Упражнение 7.2
            Console.WriteLine("Упражнение 7.2");
            Console.WriteLine("Номер счета генерируется случайно и он является уникальным");
            BankAccount2 bankAccount_2 = new BankAccount2(10023423.19, BankAccountType.Current_account);
            Console.WriteLine($"Счет под номером {bankAccount_2.AccountNumber} и типом {bankAccount_2.AccountType} содержит {bankAccount_2.AccountBalance} рублей");
            Console.ReadKey();
        }
    }
}
