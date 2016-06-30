namespace BankAccounts.Models.Customers
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Individual : ICustomer
   {
      private string name;

      public Individual(string firstName, string lastName)
      {
         this.FirstName = firstName;
         this.LastName = lastName;
         this.Name = FirstName + " " + LastName; 
      }
      private string FirstName { get; set; }
      private string LastName { get; set; }

      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            this.name = value;
         }
      }
   }
}
