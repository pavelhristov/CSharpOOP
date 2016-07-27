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

   public class BorlaExhaust:Exhaust,IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal BorlaExhaustPriceInUSADollars = 1299;
      private const int BorlaExhaustWeightInGrams = 14600;
      private const int BorlaExhaustAccelerationBonus = 12;
      private const int BorlaExhaustTopSpeedBonus = 40;

      public BorlaExhaust()
         :base(BorlaExhaustPriceInUSADollars,
         BorlaExhaustWeightInGrams,
         BorlaExhaustAccelerationBonus,
         BorlaExhaustTopSpeedBonus,
         TunningGradeType.HighGrade,
         ExhaustType.CeramicCoated)
      {

      }
   }
}
