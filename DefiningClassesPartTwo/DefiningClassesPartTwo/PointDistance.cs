namespace DefiningClassesPartTwo
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public static class PointsDistance
   {
      public static double Distance(Point3D point1, Point3D point2)
      {
         double result = Math.Sqrt(Sqr(point1.X - point2.X) + Sqr(point1.Y - point2.Y) + Sqr(point1.Z - point2.Z));
         return result;
      }

      private static double Sqr(double x)
      {
         return x * x;
      }
   }
}
