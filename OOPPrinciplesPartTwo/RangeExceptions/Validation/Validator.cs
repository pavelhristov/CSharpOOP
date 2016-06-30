namespace RangeExceptions.Validation
{
   using Exceptions;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public static class Validator<T> where T: IComparable
   {
      public static void RangeCheck(T obj, T start,T end)
      {
         string message = $"{obj} is out of the give range [{start} - {end}]";
         if (obj.CompareTo(end) <= 0 && obj.CompareTo(start) >= 0)
         {
            return;
         }else
         {
            throw new InvalidRangeException<T>(message);
         }
      }
      
   }
}
