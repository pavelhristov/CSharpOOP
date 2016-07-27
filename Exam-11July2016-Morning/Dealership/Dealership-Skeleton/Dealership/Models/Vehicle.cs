namespace Dealership.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Common.Enums;
   using Common;

   public abstract class Vehicle : IVehicle
   {
      private string make;
      private string model;
      private decimal price;
      private IList<IComment> comments;

      public Vehicle(string make, string model, decimal price)
      {
         this.Make = make;
         this.Model = model;
         this.Price = price;
         this.Comments = new List<IComment>();
      }

      public IList<IComment> Comments
      {
         get
         {
            return this.comments;
         }
         private set
         {
            this.comments = value;
         }
      }

      public string Make
      {
         get
         {
            return this.make;
         }
         private set
         {
            Validator.ValidateIntRange(value.Length, 
               Constants.MinMakeLength, 
               Constants.MaxMakeLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
            this.make = value;
         }
      }

      public string Model
      {
         get
         {
            return this.model;
         }
         private set
         {
            Validator.ValidateIntRange(value.Length,
               Constants.MinModelLength,
               Constants.MaxModelLength,
               string.Format(Constants.NumberMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
            this.model = value;
         }
      }

      public decimal Price
      {
         get
         {
            return this.price;
         }
         private set
         {
            Validator.ValidateDecimalRange(value,
               Constants.MinPrice,
               Constants.MaxPrice,
               string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
            this.price = value;
         }
      }

      public abstract VehicleType Type { get; protected set; }

      public abstract int Wheels { get; protected set; }

      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         result.AppendLine(string.Format("{0}:",this.GetType().Name));
         result.AppendLine(string.Format("  Make: {0}",this.Make));
         result.AppendLine(string.Format("  Model: {0}",this.Model));
         result.AppendLine(string.Format("  Wheels: {0}",this.Wheels));
         result.AppendLine(string.Format("  Price: ${0}",this.Price));
         result.AppendLine("  {0}");
         if (Comments.Count>0)
         {
            result.AppendLine("    --COMMENTS--");
            foreach (var comment in Comments)
            {
               result.AppendLine("    ----------");
               result.Append(comment.ToString());
               result.AppendLine("    ----------");
            }
            result.AppendLine("    --COMMENTS--");
         }else
         {
            result.AppendLine("    --NO COMMENTS--");
         }
         return result.ToString();
      }
   }
}
