namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Call
   {
      public DateTime Date { get; set; }
      public DateTime Time { get; set; }
      public string DialledPhone { get; set; }
      public double Duration { get; set; }

      public Call(DateTime date, DateTime time, string dialledPhone, double duration)
      {
         this.Date = date;
         this.Time = time;
         this.DialledPhone = dialledPhone;
         this.Duration = duration;
      }

      public override string ToString()
      {
         return $"{Date.ToString("YYYY:MM:DD")} || {Time.ToString("HH:mm")} : {DialledPhone}, dur: {Duration}";
      }
   }
}
