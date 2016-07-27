using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
   public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
   {
      private int weight;
      private decimal price;
      private int acceleration;
      private int topSpeed;
      private readonly int id;
      private IEnumerable<ITunningPart> tunningParts;

      public MotorVehicle(int weight, int acceleration, int topSpeed, decimal price)
      {
         this.id = DataGenerator.GenerateId();
         this.Weight = weight;
         this.Acceleration = acceleration;
         this.TopSpeed = topSpeed;
         this.Price = price;
         this.TunningParts = new List<ITunningPart>();
      }

      public decimal Price
      {
         get
         {
            return this.price + this.TunningParts.Sum(x => x.Price);
         }
         private set
         {
            this.price = value;
         }
      }
      public int Weight
      {
         get
         {
            return this.weight;
         }
         private set
         {
            this.weight = value;
         }
      }
      public int Acceleration
      {
         get
         {
            return this.acceleration;
         }
         private set
         {
            this.acceleration = value;
         }
      }
      public int TopSpeed
      {
         get
         {
            return this.topSpeed;
         }
         private set
         {
            this.topSpeed = value;
         }
      }
      public IEnumerable<ITunningPart> TunningParts
      {
         get
         {
            return new List<ITunningPart>(this.tunningParts);
         }
         private set
         {
            this.tunningParts = value;
         }
      }
      public int Id
      {
         get
         {
            return this.id;
         }
      }

      public void AddTunning(ITunningPart part)
      {
         var adding = this.TunningParts as List<ITunningPart>;
         adding.Add(part);
         this.TunningParts = adding as IEnumerable<ITunningPart>;
      }
      public TimeSpan Race(int trackLengthInMeters)
      {
         // Oohh boy, you shouldn't have missed the PHYSICS class in high school. 
         //Made my day!
         throw new NotImplementedException();
      }
      public bool RemoveTunning(ITunningPart part)
      {
         var removing = this.TunningParts as List<ITunningPart>;
         if (removing.Contains(part))
         {
            removing.Remove(part);
            this.TunningParts = removing as IEnumerable<ITunningPart>;
            return true;
         }
         else
         {
            return false;
         }
      }
   }
}
