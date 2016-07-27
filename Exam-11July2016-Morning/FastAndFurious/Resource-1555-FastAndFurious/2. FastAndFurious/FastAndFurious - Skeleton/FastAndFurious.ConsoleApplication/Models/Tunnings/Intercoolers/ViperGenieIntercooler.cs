namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers
{
   using Abstract;
   using Common.Enums;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class ViperGenieIntercooler : Intercooler, IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal ViperGenieIntercoolerPriceInUSADollars = 289;
      private const int ViperGenieIntercoolerWeightInGrams = 5300;
      private const int ViperGenieIntercoolerAccelerationBonus = 0;
      private const int ViperGenieIntercoolerTopSpeedBonus = 25;


      public ViperGenieIntercooler()
         : base(ViperGenieIntercoolerPriceInUSADollars,
         ViperGenieIntercoolerWeightInGrams,
         ViperGenieIntercoolerAccelerationBonus,
         ViperGenieIntercoolerTopSpeedBonus,
         TunningGradeType.MidGrade,
         IntercoolerType.ChargeAirIntercooler)
      {

      }
   }
}