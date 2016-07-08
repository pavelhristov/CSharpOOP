namespace Core.Models
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Person
   {
      private int? age;
      private string name;

      public Person(string name,int? age=null)
      {
         this.Age = age;
         this.Name = name;
      }

      public int? Age
      {
         get
         {
            return this.age;
         }
         private set
         {
            this.age = value;
         }
      }
      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            this.name = value;
         }
      }

      public override string ToString()
      {
         return $"Name: {this.Name}, Age: {(this.Age==null?"not specified": this.age.ToString())}";
      }
   }
}
