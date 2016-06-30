namespace BankAccounts.Models.Abstract
{
   using Contracts;
   using Customers;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Account : IDepositable, IAccount
   {
      private ICustomer customer;
      private decimal balance;
      private decimal interestRate;
      private decimal interestAmount;

      public Account(ICustomer customer, decimal interestRate)
      {
         this.Balance = 0m;
         this.Customer = customer;
         this.InterestRate = interestRate;
      }

      public ICustomer Customer
      {
         get
         {
            return this.customer;
         }
         private set
         {
            this.customer = value;
         }
      }

      public decimal Balance
      {
         get
         {
            return this.balance;
         }
         protected set
         {
            this.balance = value;
         }
      }

      public decimal InterestRate
      {
         get
         {
            return this.interestRate;
         }
         private set
         {
            this.interestRate = value;
         }
      }

      public decimal InterestAmount
      {
         get
         {
            return this.interestAmount;
         }
         protected set
         {
            this.interestAmount = value;
         }
      }

      public void Deposit(decimal depositMoney)
      {
         this.Balance += depositMoney;
      }

      protected abstract decimal CalculateInterestAmount(int months);
   }
}
