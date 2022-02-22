using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDLL
{
    public class Calculation
    {
        public static int Add(params int[] userInputs)
        {
            int sum = 0;

            for (int i = 0; i < userInputs.Length; i++)
            {
                sum += userInputs[i];
            }

            return sum;
        }
    }

    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountIsLessThanZeroMessage = "Debit amount is less than zero";

        private BankAccount() { }

        public BankAccount(string name, double balance)
        {
            m_customerName = name;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount",amount,DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount",amount,DebitAmountIsLessThanZeroMessage);
            }

            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }
    }

}
