using System;

namespace Laboratory_work
{
    class BankAccount2
    {
        private int account_number;
        private double account_balance;
        private BankAccountType bank_account_type;
        private static int number_of_bank_accounts = 0;

        public int AccountNumber
        {
            get
            {
                return account_number;
            }
            set
            {
                account_number = value;
            }
        }
        public double AccountBalance
        {
            get
            {
                return account_balance;
            }
            set
            {
                account_balance = Math.Round(value, 2);
            }
        }
        public BankAccountType AccountType
        {
            get
            {
                return bank_account_type;
            }
            set
            {
                bank_account_type = value;
            }
        }
        public void GenerateAnAccountNumber()
        {
            number_of_bank_accounts++;
        }

        public BankAccount2(double account_balance, BankAccountType bank_account_type)
        {
            GenerateAnAccountNumber();
            account_number = number_of_bank_accounts; 
            this.account_balance = account_balance; 
            this.bank_account_type = bank_account_type;
        }
    }
}