namespace SchoolClasses.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class SchoolClass : ISchoolClass
   {
      char identifier;
      List<Student> students;
      List<Teacher> teachers;

      public SchoolClass()
      {

      }
      public SchoolClass(char identifier, List<Student> students, List<Teacher> teachers):this()
      {
         this.identifier = identifier;
         this.students = students;
         this.teachers = teachers;
      }

      public char Identifier
      {
         get
         {
            return this.identifier;
         }
      }

      public List<Student> Students
      {
         get
         {
            return this.students;
         }
      }

      public List<Teacher> Teachers
      {
         get
         {
            return this.teachers;
         }
      }
   }
}
