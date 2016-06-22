namespace DefiningClassesPartTwo
{
   using System;
   using System.Collections;
   using System.Collections.Generic;
   using System.IO;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Program
   {
      //Problem 1-4, out of time

      
      static void Main(string[] args)
      {
         //necromancy
         //string file = "../../paths.txt";
         //Console.WriteLine(Point3D.O);
         //var point = new Point3D(1, 1, 1);

         //Console.WriteLine(PointsDistance.Distance(Point3D.O, point));

         //var path = new Path();

         //path.NextPoint(Point3D.O);
         //path.NextPoint(point);
         //path.NextPoint(new Point3D(7, 14, 5));

         //Console.WriteLine(path);
         //PathStorage.Save(path, file);

         //var listOfPaths = PathStorage.Load(file);

         //foreach (var item in listOfPaths)
         //{
         //   Console.WriteLine(item);
         //}

         GenericList<int> list = new GenericList<int>();
         list.Add(5);

         Console.WriteLine(list);
      }
   }

   class GenericList<T> 
   {
      private T[] list = new T[4];
      private int count = 0;

      public GenericList()
      {

      }

      public int Count
      {
         get
         {
            return count;
         }
      }

      public void Add(T item)
      {
         if (count<list.Length)
         {
            list[count] = item;
            count++;
         }
         else
         {
            var current = list;
            list = new T[list.Length * 2];
            current.CopyTo(list, 0);
         }
      }

      public override string ToString()
      {
         string result = string.Empty;
         for(int i = 0; i<count; i++)
         {
            result += list[i];
            if (i+1<count)
            {
               result += " "; 
            }
         }
         
         return result;
      }
   }
}
