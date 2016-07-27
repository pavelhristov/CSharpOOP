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

   public class Truck : Vehicle, IVehicle, ITruck
   {
      private int weightCapacity;
      private int wheels;

      public Truck(string make, string model, decimal price, int weightCapacity) : base(make, model, price)
      {
         this.WeightCapacity = weightCapacity;
         this.Type = VehicleType.Truck;
         this.Wheels = (int)VehicleType.Truck;
      }

      public override VehicleType Type { get; protected set; }

      public int WeightCapacity
      {
         get
         {
            return this.weightCapacity;
         }
         private set
         {
            Validator.ValidateIntRange(value,
               Constants.MinCapacity,
               Constants.MaxCapacity,
               string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
            this.weightCapacity = value;
         }
      }

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
         var capacity= string.Format("Weight Capacity: {0}t",this.WeightCapacity);
         return string.Format(base.ToString(), capacity);
      }
   }
}
