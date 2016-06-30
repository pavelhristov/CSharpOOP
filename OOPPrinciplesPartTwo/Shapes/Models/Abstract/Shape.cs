namespace Shapes.Models.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public abstract class Shape:IShapeable
   {
      private double width;
      private double height;

      public Shape()
      {

      }

      public Shape(double width, double height)
      {
         this.Width = width;
         this.Height = height;
      }

      public double Height
      {
         get
         {
            return this.height;
         }
         private set
         {
            this.height = value;
         }
      }

      public double Width
      {
         get
         {
            return this.width;
         }
         private set
         {
            this.width = value;
         }
      }

      public abstract double CalculateSurface();
   }
}
