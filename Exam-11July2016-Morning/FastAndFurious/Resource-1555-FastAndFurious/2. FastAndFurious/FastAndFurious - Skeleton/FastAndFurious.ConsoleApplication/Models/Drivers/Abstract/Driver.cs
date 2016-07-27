using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
   public abstract class Driver : IDriver
   {
      private IMotorVehicle activeVehicle;
      private readonly GenderType gender;
      private readonly int id;
      private string name;
      private IEnumerable<IMotorVehicle> vehicles;

      public Driver(string name, GenderType gender)
      {
         this.id = DataGenerator.GenerateId();
         this.Vehicles = new List<IMotorVehicle>();
         this.gender = gender;
      }

      public IMotorVehicle ActiveVehicle
      {
         get
         {
            return this.activeVehicle;
         }
         private set
         {
            if (value == null)
            {
               throw new ArgumentNullException(GlobalConstants.CannotSetNullObjectAsActiveVehicleExceptionMessage);
            }
            if (this.Vehicles.Contains(value))
            {
               this.activeVehicle = value;
            }
            else
            {
               throw new Exception(GlobalConstants.CannotSetForeignVehicleAsActiveExceptionMessage);
            }
         }
      }

      public GenderType Gender
      {
         get
         {
            return this.gender;
         }
      }

      public int Id
      {
         get
         {
            return this.id;
         }
      }

      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            this.name = value;
         }
      }

      public IEnumerable<IMotorVehicle> Vehicles
      {
         get
         {
            return this.vehicles;
         }
         private set
         {
            this.vehicles = value;
         }
      }

      public void AddVehicle(IMotorVehicle vehicle)
      {
         var adding = this.Vehicles as List<IMotorVehicle>;
         adding.Add(vehicle);
         this.Vehicles = adding as IEnumerable<IMotorVehicle>;
      }
      public bool RemoveVehicle(IMotorVehicle vehicle)
      {
         if (this.Vehicles.Contains(vehicle))
         {
            var adding = this.Vehicles as List<IMotorVehicle>;
            adding.Add(vehicle);
            this.Vehicles = adding as IEnumerable<IMotorVehicle>;

            return true;
         }
         else
         {
            return false;
         }
      }
      public void SetActiveVehicle(IMotorVehicle vehicle)
      {
         this.ActiveVehicle = vehicle;
      }
   }
}
