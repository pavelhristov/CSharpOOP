namespace Societies.Core.Infrastructure.Exceptions
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class PriceOutOfRangeException: ArgumentOutOfRangeException
   {
      public PriceOutOfRangeException(string message, decimal priceValue)
         :base(message)
      {
         this.PriceValue = priceValue;
      }

      public decimal PriceValue { get; set; }
   }
}
