namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System.Collections.Generic;
   using System.Linq;
   
   static class StudentGroups
   {
      public static List<Student> GroupTwo(Student[] students)
      {
         var result = from student in students
                      where student.GroupNumber == 2
                      orderby student.FirstName
                      select student;

         return result.ToList();
      }
      public static List<Student> ABVEmails(Student[] students)
      {
         var result = from student in students
                      where student.Email.Contains("abv.bg")
                      select student;

         return result.ToList();
      }
      public static List<Student> ByPhones(Student[] students)
      {
         var result = from student in students
                      where student.Tel.StartsWith("02")
                      select student;

         return result.ToList();
      }
      public static List<List<Mark>> MarksByJoined2006(Student[] students)
      {
         var result = from student in students
                      where student.Tel.EndsWith("06")
                      select student.Marks;

         return result.ToList();
      }
   }
}
