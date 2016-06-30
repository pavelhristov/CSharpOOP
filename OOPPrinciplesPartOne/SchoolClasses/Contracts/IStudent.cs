namespace SchoolClasses.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface IStudent : IPeople
   {
      int Classnumber { get; }
   }
}
