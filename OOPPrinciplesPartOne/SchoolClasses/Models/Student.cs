namespace SchoolClasses.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   class Student : IStudent, IPeople
   {
      int classNumber;
      string firstName;
      string lastName;

      public Student()
      {

      }

      public Student(string firstName, string lastName, int classNumber) : this()
      {
         this.firstName = firstName;
         this.lastName = lastName;
         this.classNumber = classNumber;
      }
      public int Classnumber
      {
         get
         {
            return this.classNumber;
         }
      }

      public string Name
      {
         get
         {
            return this.firstName + " " + this.lastName;
         }
      }
   }
}
