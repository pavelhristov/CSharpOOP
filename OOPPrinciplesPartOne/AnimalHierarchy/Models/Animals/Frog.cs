namespace AnimalHierarchy.Models.Animals
{
   using AnimalHierarchy.Contracts;
   using AnimalHierarchy.Models.Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Frog : Animal, ISound
   {
      public Frog(string name, string sex, int age) :base(name, sex, age)
      {

      }
      public override string ProduceSound()
      {
         return "Quack!";
      }
   }
}
