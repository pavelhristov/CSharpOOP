namespace StudentsAndWorkers.Models.Humans
{
   using Abstract;
   using Infrastructure.Constrants;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Worker : Human
   {
      public Worker(string firstName, string lastName, decimal weekSalery, int workHoursPerDay):base(firstName,lastName)
      {
         this.WeekSalery = weekSalery;
         this.WorkHoursPerDay = workHoursPerDay;
      }

      public decimal WeekSalery { get; private set; }
      public int WorkHoursPerDay { get; private set; }

      public decimal MoneyPerHour()
      {
         decimal result = this.WeekSalery/(WorkHoursPerDay*ValidationConstants.WorkDays);
         
         return result;
      }

      public override string ToString()
      {
         return $"{this.FirstName} {this.LastName} - {this.MoneyPerHour().ToString("F")} $";
      }
   }
}
