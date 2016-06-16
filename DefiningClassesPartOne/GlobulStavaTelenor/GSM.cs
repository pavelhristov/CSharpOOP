namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class GSM
   {
      private string model;
      private string manufacturer;
      private int? price;
      private string owner;
      private Battery batteryCharacteristics;
      private Display displayCharacteristics;
      private static GSM iPhone4s = new GSM("iPhone4S", "Apple", 210, "Pesho", new Battery(BatteryType.Li_Po, 200, 14), new Display("640 x 960", 16000000));
      private List<Call> callHistory = new List<Call>();

      public GSM(string model, string manufacturer, int? price = null, string owner = null, Battery batteryCharacteristics = null, Display displayCharacteristics = null)
      {
         this.model = model;
         this.manufacturer = manufacturer;
         this.price = price;
         this.owner = owner;
         this.batteryCharacteristics = batteryCharacteristics;
         this.displayCharacteristics = displayCharacteristics;
      }
      public string Model
      {
         get
         {
            return this.model;
         }
      }
      public string Manufacturer
      {
         get
         {
            return this.manufacturer;
         }
      }
      public int? Price
      {
         get
         {
            return this.price;
         }
      }
      public string Owner
      {
         get
         {
            return this.owner;
         }
      }
      public Battery BatteryCharacteristics
      {
         get
         {
            return this.batteryCharacteristics;
         }
      }
      public Display DisplayCharacteristics
      {
         get
         {
            return this.displayCharacteristics;
         }
      }
      public static GSM IPhone4S
      {
         get
         {
            return iPhone4s;
         }
      }
      public List<Call> CallHistory
      {
         get
         {
            return this.callHistory;
         }
      }
      public void AddCall(DateTime date, DateTime time, string dialledPhone, double duration)
      {
         this.callHistory.Add(new Call(date, time, dialledPhone, duration));
         Console.WriteLine("New call registered!");
      }

      public void DeleteCall(Call call)
      {
         this.callHistory.Remove(call);
         Console.WriteLine("The call has been deleted!");
      }

      public void ClearHistory()
      {
         this.callHistory.Clear();
         Console.WriteLine("Call history has been cleared!");
      }

      public void ShowCallHistory()
      {
         foreach (var item in CallHistory)
         {
            Console.WriteLine(item);
         }
      }

      public override string ToString()
      {
         return "GSM: " + Model + " " + Manufacturer + " :" + Price + "lv. " + Owner + " " + BatteryCharacteristics.ToString() + " " + DisplayCharacteristics.ToString();
      }
   }
}
