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


   public class EvolutionXPerformanceIntercooler : Intercooler, IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
   {

      private const decimal EvolutionXPerformanceIntercoolerPriceInUSADollars = 499;
      private const int EvolutionXPerformanceIntercoolerWeightInGrams = 4500;
      private const int EvolutionXPerformanceIntercoolerAccelerationBonus = -5;
      private const int EvolutionXPerformanceIntercoolerTopSpeedBonus = 40;


      public EvolutionXPerformanceIntercooler()
         : base(EvolutionXPerformanceIntercoolerPriceInUSADollars,
         EvolutionXPerformanceIntercoolerWeightInGrams,
         EvolutionXPerformanceIntercoolerAccelerationBonus,
         EvolutionXPerformanceIntercoolerTopSpeedBonus,
         TunningGradeType.HighGrade,
         IntercoolerType.AirToLiquidIntercooler)
      {

      }
   }
}