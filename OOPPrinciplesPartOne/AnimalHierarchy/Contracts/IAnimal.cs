namespace AnimalHierarchy.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface IAnimal
   {
      string Name { get; }
      string Sex { get; }
      int Age { get; }
   }
}
