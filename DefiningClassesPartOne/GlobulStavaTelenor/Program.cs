namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   class Program
   {
      /*  I didn't have clear idea how to oragnize things proper,
       *  pretty sure it's a huge mess.
       *  Thanks for trying and good luck!
       */




      static void Main(string[] args)
      {
         //wicked magic

         Battery battery = new Battery(BatteryType.Li_Ion, 50, 20);  //default battery
         Display display = new Display();                            //default display
         //GSM gsm = new GSM("2730 Classic", "Nokia", 40, "Pesho", battery, display);         //test GSM ctor

         //Console.WriteLine(gsm.ToString());                                        //testing ToString()
         //Console.WriteLine(gsm.BatteryCharacteristics.ToString());
         //Console.WriteLine(GSM.IPhone4S.ToString());



         ////GSMTest testing and CallHistory operations
         //GSMTest.AddPhone(new GSM("2730 Classic", "Nokia", 40, "Pesho", battery, display));

         //GSMTest.DisplayPhones();

         //GSMTest.IPhone4SFanClub();

         //GSMTest.Phones[0].AddCall(DateTime.Now.Date, DateTime.Now, "0888888878", 10.12);

         //GSMTest.Phones[0].ShowCallHistory();

         //GSMTest.Phones[0].DeleteCall(GSMTest.Phones[0].CallHistory[0]);
         //GSMTest.Phones[0].ShowCallHistory();


         //GSMCallHistoryTest testing
         GSMCallHistoryTest.Test();
      }
   }
}
