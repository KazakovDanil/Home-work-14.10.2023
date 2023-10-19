using System;

namespace Laboratory_work
{
    public enum BankAccountType
    {
        Savings_account = 1,
        Current_account
    }
    class BankAccount1
    {
        private ulong account_number;
        private double account_balance;
        private BankAccountType bank_account_type;

        public ulong AccountNumber
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

        // public BankAccount(ulong account_number, double account_balance, BankAccountType bank_account_type)
        // { this.account_number = account_number; this.account_balance = account_balance; this.bank_account_type = bank_account_type; }
    }
}