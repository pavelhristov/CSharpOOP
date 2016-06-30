namespace SchoolClasses.Contracts
{
   using Models;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface ISchoolClass
   {
      char Identifier { get; }
      List<Student> Students { get; }
      List<Teacher> Teachers { get; }
   }
}
