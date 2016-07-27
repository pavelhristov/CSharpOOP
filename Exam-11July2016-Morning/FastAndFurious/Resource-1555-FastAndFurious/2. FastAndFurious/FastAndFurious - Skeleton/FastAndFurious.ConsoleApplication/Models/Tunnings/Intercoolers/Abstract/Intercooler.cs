namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract
{
   using Common.Enums;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Tunnings.Abstract;

   public class Intercooler : TunningPart, IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      public Intercooler(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType, IntercoolerType intercoolerType)
         : base(price, weight, acceleration, topSpeed, gradeType)
      {
         this.IntercoolerType = intercoolerType;
      }

      public IntercoolerType IntercoolerType { get; private set; }
   }
}
