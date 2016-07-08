namespace Societies.Core.Infrastructure.Utils
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading;
   using System.Threading.Tasks;

   static class DataGenerator
   {
      private static int counter;

      static DataGenerator()
      {
         counter = 0;
      }
      public static int GenerateUniqueId()
      {
         return Interlocked.Increment(ref counter);
      }
   }
}
