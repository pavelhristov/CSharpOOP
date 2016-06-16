namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class GSMTest
   {
      private static List<GSM> phones = new List<GSM>();

      public static List<GSM> Phones
      {
         get
         {
            return phones;
         }

         set
         {
            phones = value;
         }
      }

      public static void AddPhone(GSM gsm)
      {
         phones.Add(gsm);
      }

      public static void IPhone4SFanClub()
      {
         Console.WriteLine(GSM.IPhone4S.ToString());
      }

      public static void DisplayPhones()
      {
         foreach (var item in phones)
         {
            Console.WriteLine(item);
         }
      }
   }
}
