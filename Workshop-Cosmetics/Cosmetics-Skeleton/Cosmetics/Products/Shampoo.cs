using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
   public class Shampoo :AProduct, IShampoo, IProduct
   {
      private uint milliliters;
      private UsageType usage;

      public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
         :base(name,brand,price,gender)
      {
         this.Milliliters = milliliters;
         this.Usage = usage;
      }

     

      public uint Milliliters
      {
         get
         {
            return this.milliliters;
         }
         private set
         {
            Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
            this.milliliters = value;
         }
      }

      public UsageType Usage {
         get
         {
            return this.usage;
         }
             private set
         {
            Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
            this.usage = value;
         }
      }

      public override string Print()
      {
         StringBuilder builder = new StringBuilder();


         builder.AppendLine(base.Print());
         builder.AppendLine($"* Quantity: { this.Milliliters} ml");
         builder.AppendLine($"* Usage: {this.Usage}");

         return builder.ToString();
      }
   }
}
