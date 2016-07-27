namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
   using Abstract;
   using Common.Enums;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class ZX8ParallelTwinTurbocharger : Turbocharger, ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal ZX8ParallelTwinTurbochargerPriceInUSADollars = 699;
      private const int ZX8ParallelTwinTurbochargerWeightInGrams = 3900;
      private const int ZX8ParallelTwinTurbochargerAccelerationBonus = 10;
      private const int ZX8ParallelTwinTurbochargerTopSpeedBonus = 85;

      public ZX8ParallelTwinTurbocharger()
         :base(ZX8ParallelTwinTurbochargerPriceInUSADollars,
         ZX8ParallelTwinTurbochargerWeightInGrams,
         ZX8ParallelTwinTurbochargerAccelerationBonus,
         ZX8ParallelTwinTurbochargerTopSpeedBonus,
         TunningGradeType.HighGrade,
         TurbochargerType.TwinTurbo)
      {

      }
   }
}
