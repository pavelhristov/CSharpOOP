namespace AnimalHierarchy.Models.Animals
{
   using Abstract;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Tomcat : Cat, ISound
   {
      public Tomcat(string name, int age) : base(name, "male", age)
      {

      }
   }
}
