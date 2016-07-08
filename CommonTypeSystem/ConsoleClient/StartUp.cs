namespace ConsoleClient
{
   using Core.Models;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class StartUp
   {
      /* Greetings!
       * Problem 1-4, times up.
       * haven't implemented interfaces or abstracts that werent requared
       */



      static void Main(string[] args)
      {
         Person person1 = new Person("Pesho");
         Person person2 = new Person("Gosho", 31);

         Console.WriteLine(person1);
         Console.WriteLine(person2);
      }
   }
}
