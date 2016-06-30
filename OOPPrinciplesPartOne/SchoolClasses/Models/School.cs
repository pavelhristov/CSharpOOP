namespace SchoolClasses.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class School : ISchool
   {
      List<SchoolClass> schoolClasses;

      public List<SchoolClass> SchoolClasses
      {
         get
         {
            return this.schoolClasses;
         }
      }
   }
}
