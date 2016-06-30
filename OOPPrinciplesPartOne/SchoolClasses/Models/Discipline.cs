namespace SchoolClasses.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Discipline : IDiscipline
   {
      string name;
      int lections;
      int exercises;

      public Discipline()
      {

      }

      public Discipline(string name, int lections, int exercises):this()
      {
         this.name = name;
         this.lections = lections;
         this.exercises = exercises;
      }

      public int Exercises
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public int Lections
      {
         get
         {
            throw new NotImplementedException();
         }
      }

      public string Name
      {
         get
         {
            throw new NotImplementedException();
         }
      }
   }
}
