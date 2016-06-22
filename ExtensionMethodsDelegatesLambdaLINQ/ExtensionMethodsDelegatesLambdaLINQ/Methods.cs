namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System;
   using System.Linq;

   public static class Methods
   {
      public static void DivisionBySevenAndThreeLINQ(int[] numbers)
      {
         var result = from num in numbers
                      where (num % 7 == 0) && (num % 3 == 0)
                      select num;
         Console.WriteLine(string.Join(" ", result));
      }
      public static void DivisionBySevenAndThree(int[] numbers)
      {
         //TODO
         var result = numbers.Where(x => (x % 7 == 0 && x % 3 == 0));
         Console.WriteLine(string.Join(" ", result));
      }
   }
}
