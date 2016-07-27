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

   public class Motorcycle : Vehicle, IVehicle, IMotorcycle
   {
      private string category;
      private int wheels;

      public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
      {
         this.Category = category;
         this.Type = VehicleType.Motorcycle;
         this.Wheels = (int)VehicleType.Motorcycle;
      }

      public string Category
      {
         get
         {
            return this.category;
         }
         private set
         {
            Validator.ValidateIntRange(value.Length, 
               Constants.MinCategoryLength, 
               Constants.MaxCategoryLength, 
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
            this.category = value;
         }
      }

      public override VehicleType Type { get; protected set; }

      public override int Wheels
      {
         get
         {
            return this.wheels;
         }
         protected set
         {
            Validator.ValidateIntRange(value,
               Constants.MinWheels,
               Constants.MaxWheels,
               string.Format(Constants.NumberMustBeBetweenMinAndMax, "Wheels", Constants.MinWheels, Constants.MaxWheels));
            this.wheels = value;
         }
      }

      public override string ToString()
      {
         var category = string.Format("Category: {0}",this.Category);
         return string.Format(base.ToString(), category);
      }
   }
}
