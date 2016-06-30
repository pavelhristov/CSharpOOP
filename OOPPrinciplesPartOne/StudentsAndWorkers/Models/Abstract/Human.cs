namespace StudentsAndWorkers.Models.Abstract
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Human
   {
      string firstName;
      string lastName;

      public Human()
      {

      }
      public Human(string firstName, string lastName):this()
      {
         this.firstName = firstName;
         this.lastName = lastName;
      }
      public string FirstName
      {
         get
         {
            return this.firstName;
         }
      }
      public string LastName
      {
         get
         {
            return this.lastName;
         }
      }
   }
}
