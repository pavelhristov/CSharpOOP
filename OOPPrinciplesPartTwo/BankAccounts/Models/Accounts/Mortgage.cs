namespace BankAccounts.Models.Accounts
{
   using Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Contracts;
   using Customers;

   public class Mortgage : Account
   {

      public Mortgage(ICustomer customer, int months,decimal loanedMoney, decimal interestRate) : base(customer, interestRate)
      {
         this.InterestAmount = CalculateInterestAmount(months);
         this.Balance -= loanedMoney + loanedMoney * InterestAmount;
      }

      protected override decimal CalculateInterestAmount(int months)
      {
         decimal result = 0;
         if (this.Customer.GetType() == typeof(Company))
         {
            for (int i = 1; i < months + 1; i++)
            {
               if (i <= 12)
               {
                  result += this.InterestRate / 2;
               }
               else
               {
                  result += this.InterestRate;
               }
            }
         }
         else if (this.Customer.GetType() == typeof(Individual))
         {
            for (int i = 7; i < months + 1; i++)
            {
               result += this.InterestRate;
            }
         }

         return result;
      }
   }
}
