namespace SchoolClasses.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface IDiscipline
   {
      string Name { get; }
      int Lections { get; }
      int Exercises { get; }
   }
}
