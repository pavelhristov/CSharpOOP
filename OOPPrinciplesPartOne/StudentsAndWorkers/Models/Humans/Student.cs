namespace StudentsAndWorkers.Models.Humans
{
   using Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Student : Human
   {
      int grade;

      public Student(string firstName, string lastName, int grade):base(firstName,lastName)
      {
         this.grade = grade;
      }

      public int Grade
      {
         get
         {
            return this.grade;
         }
      }

      public override string ToString()
      {
         return $"{this.FirstName} {this.LastName} - {grade}";
      }
   }
}
