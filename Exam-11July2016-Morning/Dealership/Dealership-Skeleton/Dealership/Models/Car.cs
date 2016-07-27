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

   public class Car : Vehicle, IVehicle, ICar
   {
      private int seats;
      private int wheels;

      public Car(string make, string model, decimal price, int seats) : base(make, model, price)
      {
         this.Seats = seats;
         this.Type = VehicleType.Car;
         this.Wheels = (int)VehicleType.Car;
      }

      public int Seats
      {
         get
         {
            return this.seats;
         }
         private set
         {
            Validator.ValidateIntRange(value,
               Constants.MinSeats, 
               Constants.MaxSeats, 
               string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
            this.seats = value;
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
         var seats = string.Format("Seats: {0}",this.Seats);
         return string.Format( base.ToString(),seats);
      }
   }
}
