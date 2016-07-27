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

   public class VortexR35SequentialTurbocharger:Turbocharger,ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal VortexR35SequentialTurbochargerPriceInUSADollars = 699;
      private const int VortexR35SequentialTurbochargerWeightInGrams = 3900;
      private const int VortexR35SequentialTurbochargerAccelerationBonus = 10;
      private const int VortexR35SequentialTurbochargerTopSpeedBonus = 85;

      public VortexR35SequentialTurbocharger()
         :base(VortexR35SequentialTurbochargerPriceInUSADollars,
         VortexR35SequentialTurbochargerWeightInGrams,
         VortexR35SequentialTurbochargerAccelerationBonus,
         VortexR35SequentialTurbochargerTopSpeedBonus,
         TunningGradeType.HighGrade,
         TurbochargerType.SequentialTurbo)
      {

      }
   }
}