namespace BankAccounts.Models.Customers
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Company : ICustomer
   {
      private string name;

      public Company(string name)
      {
         this.Name = name;
      }

      public string Name
      {
         get
         {
            return this.Name;
         }
         private set
         {
            this.name = value;
         }
      }
   }
}
