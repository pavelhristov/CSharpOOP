namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   static class GSMCallHistoryTest
   {
      const double pricePerMinute = 0.37;

      public static void Test()
      {
         //Creating an instance of the GSM class.
         Battery battery = new Battery(BatteryType.Li_Ion, 50, 20);
         Display display = new Display();
         var gsm = new GSM("2730 Classic", "Nokia", 40, "Pesho", battery, display);

         //Adding few calls.
         gsm.AddCall(DateTime.Now.Date, DateTime.Now, "0888888878", 10.12);
         gsm.AddCall(DateTime.Now.Date, DateTime.Now, "0888888878", 1.00);
         gsm.AddCall(DateTime.Now.Date, DateTime.Now, "0888888878", 5.18);
         gsm.AddCall(DateTime.Now.Date, DateTime.Now, "0888888878", 2.55);
         Console.WriteLine();

         //Displaying the information about the calls.
         gsm.ShowCallHistory();
         Console.WriteLine();

         //Calculating the total price of the calls in the history.
         Console.WriteLine($"{PriceOfCalls(gsm):F2} lv.");
         Console.WriteLine();

         // Removing the longest call from the history and calculate the total price again.
         DeleteLongestCall(gsm);
         Console.WriteLine();

         //Clearing the call history and print it.
         var newPrice = PriceOfCalls(gsm);
         gsm.ClearHistory();
         Console.WriteLine($"{newPrice:F2} lv.");
         Console.WriteLine();
      }

      public static double PriceOfCalls(GSM gsm)
      {
         double result = 0;

         double duration = 0;

         foreach (var item in gsm.CallHistory)
         {
            duration += item.Duration;
         }

         result = duration * pricePerMinute;


         return result;
      }

      public static void DeleteLongestCall(GSM gsm)
      {
         Call longestCall = gsm.CallHistory[0];

         foreach (var item in gsm.CallHistory)
         {
            if (item.Duration > longestCall.Duration)
            {
               longestCall = item;
            }
         }

         gsm.DeleteCall(longestCall);
      }
   }
}
