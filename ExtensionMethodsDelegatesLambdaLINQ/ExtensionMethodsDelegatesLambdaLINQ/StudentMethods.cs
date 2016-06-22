namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System;
   using System.Collections.Generic;
   using System.Linq;


   static class StudentMethods
   {
      public static int FirstBeforeLast(Student[] students)
      {
         var result = students.Where(x => (x.FirstName).CompareTo(x.LastName) < 0);
         //int result = 0;
         //foreach (var student in students)
         //{
         //   if (student.FirstName.CompareTo(student.LastName) < 0)
         //   {
         //      result++;
         //   }
         //}

         return result.Count();
      }

      public static void AgeRange(Student[] students)
      {
         var result = from x in students
                      where(((x.Age >= 18) && (x.Age <= 24)) == true)
                      select new { x.FirstName, x.LastName };

         foreach (var item in result)
         {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
         }
      }

      public static Student[] Sort(Student[] students)
      {
         var result = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToArray();

         return result;
      }
      public static Student[] SortLINQ(Student[] students)
      {
         var result = from x in students
                      orderby x.LastName
                      orderby x.FirstName
                      select x;

         return result.ToArray();
      }
      public static void ExelentStudents(Student[] students)
      {
         var result = from student in students
                      from subj in student.Marks
                      where subj.Note == 6
                      select new { student.FirstName, student.LastName };

         foreach (var item in result)
         {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
         }
      }
   }
}
