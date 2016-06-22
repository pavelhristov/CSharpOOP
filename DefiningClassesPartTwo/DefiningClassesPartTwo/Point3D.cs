namespace DefiningClassesPartTwo
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public struct Point3D
   {
      //fields
      private int x, y, z;
      private static readonly Point3D o;

      //constuctors
      static Point3D()
      {
         o = new Point3D(0, 0, 0);
      }

      public Point3D(int x, int y, int z)
      {
         this.x = x;
         this.y = y;
         this.z = z;
      }

      //properties
      public int X
      {
         get
         {
            return this.x;
         }
         set
         {
            this.x = value;
         }
      }

      public int Y
      {
         get
         {
            return this.y;
         }
         set
         {
            this.y = value;
         }
      }

      public int Z
      {
         get
         {
            return this.z;
         }
         set
         {
            this.z = value;
         }
      }

      public static Point3D O
      {
         get
         {
            return o;
         }
      }

      //methods
      public override string ToString()
      {
         return $"({x},{y},{z})";
      }
   }
}
