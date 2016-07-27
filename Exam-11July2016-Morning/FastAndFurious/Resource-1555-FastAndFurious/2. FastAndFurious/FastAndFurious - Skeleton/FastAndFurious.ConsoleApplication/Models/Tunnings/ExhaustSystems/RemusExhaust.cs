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

   public class RemusExhaust : Exhaust, IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal RemusExhaustPriceInUSADollars = 679;
      private const int RemusExhaustWeightInGrams = 11500;
      private const int RemusExhaustAccelerationBonus = 8;
      private const int RemusExhaustTopSpeedBonus = 32;

      public RemusExhaust()
         : base(RemusExhaustPriceInUSADollars,
         RemusExhaustWeightInGrams,
         RemusExhaustAccelerationBonus,
         RemusExhaustTopSpeedBonus,
         TunningGradeType.MidGrade,
         ExhaustType.StainlessSteel)
      {

      }
   }
}