namespace BankAccounts.Models.Accounts
{
   using Abstract;
   using Contracts;
   using Customers;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Deposit : Account, IDrawable
   {

      public Deposit(ICustomer customer, int months,decimal deposit, decimal interestRate) : base(customer,interestRate)
      {
         this.InterestAmount = CalculateInterestAmount(months);
         this.Balance += deposit + deposit * this.InterestAmount;
      }
      

      protected override decimal CalculateInterestAmount(int months)
      {
         decimal result = 0;
         if (this.GetType() == typeof(Company))
         {
            if (this.Balance >= 1000)
            {
               result = months * this.InterestRate;
            }
         };

         return result;
      }

      public void Draw(decimal drawMoney)
      {
         this.Balance -= drawMoney;
      }

   }
}
