namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Battery
   {
      private BatteryType model;
      private int hoursIdle;
      private int hoursTalk;

      public Battery(BatteryType model, int hoursIdle, int hoursTalk)
      {
         this.model = model;
         this.hoursIdle = hoursIdle;
         this.hoursTalk = hoursTalk;
      }
      public BatteryType Model
      {
         get
         {
            return this.model;
         }
      }
      public int HoursIdle
      {
         get
         {
            return this.hoursIdle;
         }
      }
      public int HoursTalk
      {
         get
         {
            return this.hoursTalk;
         }
      }
      public override string ToString()
      {
         return "Battery: " + Model + " " + HoursIdle + " " + HoursTalk;
      }
   }

   public enum BatteryType
   {
      Li_Ion,
      Li_Po,
      NiMH,
      NiCd
   }
}
