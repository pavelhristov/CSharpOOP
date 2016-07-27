namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
   using Abstract;
   using Common.Enums;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class MagnaflowExhaust : Exhaust, IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal MagnaflowExhaustPriceInUSADollars = 379;
      private const int MagnaflowExhaustWeightInGrams = 12800;
      private const int MagnaflowExhaustAccelerationBonus = 5;
      private const int MagnaflowExhaustTopSpeedBonus = 25;

      public MagnaflowExhaust()
         :base(MagnaflowExhaustPriceInUSADollars,
         MagnaflowExhaustWeightInGrams,
         MagnaflowExhaustAccelerationBonus,
         MagnaflowExhaustTopSpeedBonus,
         TunningGradeType.LowGrade,
         ExhaustType.NickelChromePlated)
      {

      }
   }
}

