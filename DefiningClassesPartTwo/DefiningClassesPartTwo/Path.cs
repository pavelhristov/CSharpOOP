namespace DefiningClassesPartTwo
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Path
   {
      private List<Point3D> pathList = new List<Point3D>();

      public void NextPoint(Point3D point)
      {
         this.pathList.Add(point);
      }

      public override string ToString()
      {
         string result = string.Join("; ", pathList);

         return result;
      }
   }
}
