namespace RangeExceptions.Exceptions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class InvalidRangeException<T>: ArgumentOutOfRangeException 
   {

      public InvalidRangeException(string message):base(message)
      {

      }
   }
}
