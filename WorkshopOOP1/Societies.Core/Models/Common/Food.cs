namespace Societies.Core.Models.Common
{
   using Contracts;
   using Infrastructure.Enumerations.Common;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Food : Consumable, IFood
   {
      public FoodType Type { get; set; }
      public int PortionSizeInGrams { get; set; }
      public decimal Price { get; set; }
   }
}
