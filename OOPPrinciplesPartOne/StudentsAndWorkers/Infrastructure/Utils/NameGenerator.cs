namespace StudentsAndWorkers.Infrastructure.Utils
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public static class NameGenerator
   {
      static string[] firstName =
      {
         "Jon",
         "Tyrion",
         "Bran",
         "Sansa",
         "Daenerys",
         "Margaery",
         "Cersei",
         "Edward",
         "Tormund",
         "Jorah",
         "Stanis",
         "Ramsay",
         "Hodor"
      };

      static string[] lastName =
      {
         "Snow",
         "Lannister",
         "Stark",
         "Targerian",
         "Tyrell",
         "Baratheon",
         "Mormont",
         "Bolton",
         "Hodor?"
      };

      public static string FirstName(Random rng)
      {
         string result = string.Empty;
         result = firstName[rng.Next(0,firstName.Length)];

         return result;
      }

      public static string LastName(Random rng)
      {
         string result = string.Empty;
         result = lastName[rng.Next(0, lastName.Length)];

         return result;
      }
   }
}
