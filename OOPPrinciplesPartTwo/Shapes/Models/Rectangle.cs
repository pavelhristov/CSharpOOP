﻿namespace Shapes.Models
{
   using Abstract;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Rectangle : Shape
   {
      public Rectangle(double width, double height):base(width,height)
      {

      }

      public override double CalculateSurface()
      {
         double result = 0;

         result = this.Width * this.Height;

         return result;
      }
   }
}
