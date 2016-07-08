using Societies.Core.Contracts;
namespace Societies.Core.Models.Common
{
   using Societies.Core.Infrastructure.Exceptions;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Consumable : IConsumable
   {
      private decimal totalPrice;
      public decimal TotalPrice
      {
         get
         {
            return this.totalPrice;
         }

         set
         {
            if (value<0)
            {
               throw new PriceOutOfRangeException("Price was not in desired range[0:in",value);
            }
            else if (value>decimal.MaxValue)
            {
               throw new PriceOutOfRangeException("Price was not in desired range[0:in",value);
            }
         }
      }
      
   }
}
