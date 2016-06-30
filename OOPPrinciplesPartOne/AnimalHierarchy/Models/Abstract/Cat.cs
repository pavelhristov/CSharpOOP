namespace AnimalHierarchy.Models.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Cat:Animal,ISound
   {
      public Cat(string name, string sex, int age) :base(name,sex,age)
      {

      }
      public override string ProduceSound()
      {
         return "Meow!";
      }
   }
}
