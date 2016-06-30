namespace AnimalHierarchy.Models.Animals
{
   using AnimalHierarchy.Contracts;
   using AnimalHierarchy.Models.Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Kitten : Cat, ISound
   {
      public Kitten(string name, int age) : base(name, "female", age)
      {
      }
   }
}
