namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Common.Enums;
   using Common.Utils;

   public abstract class TunningPart : ITunningPart
   {
      private int acceleration;
      private readonly int id;
      private int topSpeed;
      private int weight;
      private decimal price;

      public TunningPart(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType)
      {
         this.Acceleration = acceleration;
         this.TopSpeed = topSpeed;
         this.Weight = weight;
         this.Price = price;
         this.id = DataGenerator.GenerateId();
         this.GradeType = gradeType;
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

      public TunningGradeType GradeType { get; private set; }

      public int Id
      {
         get
         {
            return this.id;
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
            this.price = value;
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
   }
}
