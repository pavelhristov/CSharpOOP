namespace Shapes.Models
{
   using Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Square : Shape
   {
      public Square(double width, double height):base(width,height)
      {
         if (width!=height)
         {
            throw new ArgumentOutOfRangeException("Height and Width must have the same value for Square");
         }
      }
      public override double CalculateSurface()
      {
         double result = 0;

         result = this.Width * this.Height;

         return result;
      }
   }
}
