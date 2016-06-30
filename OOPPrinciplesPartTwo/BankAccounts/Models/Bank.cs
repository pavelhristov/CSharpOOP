namespace BankAccounts.Models
{
   using Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Bank
   {
      private List<Account> accounts;

      public Bank(List<Account> accounts)
      {
         this.Accounts = accounts;
      }

      public List<Account> Accounts
      {
         get
         {
            return this.accounts;
         }
         private set
         {
            this.accounts = value;
         }
      }
   }
}
