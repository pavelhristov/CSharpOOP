using SchoolClasses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Models
{
   class Teacher : IPeople, ITeacher
   {
      string firstName;
      string lastName;
      List<Discipline> disciplines;

      public Teacher()
      {

      }

      public Teacher(string firstName, string lastName, List<Discipline> disciplines) : this()
      {
         this.firstName = firstName;
         this.lastName = lastName;
         this.disciplines = disciplines;
      }

      public string Name
      {
         get
         {
            return this.firstName + " " + this.lastName;
         }
      }

      public List<Discipline> Disciplines
      {
         get
         {
            return this.disciplines;
         }
      }
   }
}
