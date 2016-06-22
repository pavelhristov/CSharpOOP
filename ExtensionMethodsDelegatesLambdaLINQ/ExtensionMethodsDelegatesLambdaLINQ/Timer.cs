namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System;
   using System.Diagnostics;

   static class Timer
   {
      public static void ExecuteEachTime(Action func, int t)
      {
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Start();
         while (true)
         {
            if (stopwatch.ElapsedMilliseconds>=t*1000)
            {
               func();
               stopwatch.Restart();
            }
         }

      }
   }
}
