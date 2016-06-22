namespace DefiningClassesPartTwo
{
   using System;
   using System.Collections.Generic;
   using System.IO;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public static class PathStorage
   {
      public static void Save(Path path, string fileLocation)
      {
         StreamWriter streamWriter = new StreamWriter(fileLocation, true);
         using (streamWriter)
         {
            streamWriter.WriteLine(path);
         }
      }

      public static List<Path> Load(string fileLocation)
      {
         var result = new List<Path>();
         StreamReader streamReader = new StreamReader(fileLocation);
         using (streamReader)
         {
            string line = streamReader.ReadLine();
            while (line != null)
            {
               var currentPath = new Path();
               var points = line.Split(new[] { ' ', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
               foreach (var item in points)
               {
                  var point = item.Split(',').Select(int.Parse).ToArray();
                  currentPath.NextPoint(new Point3D(point[0], point[1], point[2]));
               }
               line = streamReader.ReadLine();
               result.Add(currentPath);
            }
         }

         return result;
      }

      //public static void ClearStorage(string fileLocation)
      //{
      //   try
      //   {
      //      File.Delete(fileLocation);
      //   }
      //   catch (IOException e)
      //   {
      //      Console.WriteLine("File not found", e);
      //   }
      //}
   }
}
