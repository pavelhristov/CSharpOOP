namespace Societies.Core.Models.Common
{
   using Infrastructure.Enumerations.Common;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Beverage : Consumable
   {
      public BeverageType Type { get; set; }
      public int SizeOfPortionInGrams { get; set; }
   }
}
