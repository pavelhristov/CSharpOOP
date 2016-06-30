namespace AnimalHierarchy.Models.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Animal:ISound,IAnimal
   {
      int age;
      string sex;
      string name;

      public Animal()
      {

      }
      public Animal(string name, string sex, int age)
      {
         this.age = age;
         this.sex = sex;
         this.name = name;
      }
      public int Age
      {
         get
         {
            return this.age;
         }
      }
      public string Sex
      {
         get
         {
            return this.sex;
         }
      }
      public string Name
      {
         get
         {
            return this.name;
         }
      }

      public abstract string ProduceSound();
   }
}
