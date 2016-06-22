namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;


   static class Extensions
   {
      //StringBuiler extensions
      public static StringBuilder SubString(this StringBuilder builder, int index, int length)
      {
         StringBuilder result = new StringBuilder();

         for (int i = index; i < index + length; i++)
         {
            result.Append(builder[i]);
         }

         return result;
      }

      //IEnumerable extensions
      //Sum
      public static string ExtensionSum<T>(this IEnumerable<T> collection)
      {
         StringBuilder result = new StringBuilder();
         foreach (var item in collection)
         {
            result.Append(item.ToString());
         }

         return result.ToString();
      }
      public static int ExtensionSum(this IEnumerable<int> collection)
      {
         int result = default(int);
         foreach (var item in collection)
         {
            result += item;
         }

         return result;
      }
      public static double ExtensionSum(this IEnumerable<double> collection)
      {
         double result = default(double);
         foreach (var item in collection)
         {
            result += item;
         }

         return result;
      }
      //Product
      public static string ExtensionProduct<T>(this IEnumerable<T> collection)
      {
         return "incorrect type";
      }
      public static int ExtensionProduct(this IEnumerable<int> collection)
      {
         int result = default(int);
         foreach (var item in collection)
         {
            result *= item;
         }

         return result;
      }
      public static double ExtensionProduct(this IEnumerable<double> collection)
      {
         double result = default(double);
         foreach (var item in collection)
         {
            result *= item;
         }

         return result;
      }
      //Min
      public static string ExtensionMin<T>(this IEnumerable<T> collection)
      {
         return "incorrect type";
      }
      public static int ExtensionMin(this IEnumerable<int> collection)
      {
         int result = int.MaxValue;
         foreach (var item in collection)
         {
            if (result > item)
            {
               result = item;
            }
         }

         return result;
      }
      public static double ExtensionMin(this IEnumerable<double> collection)
      {
         double result = double.MaxValue;
         foreach (var item in collection)
         {
            if (result > item)
            {
               result = item;
            }
         }

         return result;
      }
      //Max
      public static string ExtensionMax<T>(this IEnumerable<T> collection)
      {
         return "incorrect type";
      }
      public static int ExtensionMax(this IEnumerable<int> collection)
      {
         int result = int.MinValue;
         foreach (var item in collection)
         {
            if (result < item)
            {
               result = item;
            }
         }

         return result;
      }
      public static double ExtensionMax(this IEnumerable<double> collection)
      {
         double result = double.MinValue;
         foreach (var item in collection)
         {
            if (result < item)
            {
               result = item;
            }
         }

         return result;
      }
      //Avarage
      public static string ExtensionAverage<T>(this IEnumerable<T> collection)
      {
         return "incorrect type";
      }
      public static double ExtensionAverage(this IEnumerable<double> collection)
      {
         double result = 0;
         int count = 0;
         foreach (var item in collection)
         {
            result += item;
            count++;
         }

         return result / count;
      }
      public static int ExtensionAverage(this IEnumerable<int> collection)
      {
         int result = 0;
         int count = 0;
         foreach (var item in collection)
         {
            result += item;
            count++;
         }

         return result / count;
      }
      //MarkExtensions
      public static int Has2(this Mark mark)
      {
         if (mark.Note == 2)
         {
            return 1;
         }
         return 0;
      }
      //StudentGroupExtensions
      public static bool HasTwo2(this Student student)
      {
         int count = 0;
         foreach (var item in student.Marks)
         {
            count += item.Has2();
         }

         return count == 2 ? true : false;
      }
      public static void GroupedByGroupNumber(this Student[] students)
      {
         var result = from student in students
                      orderby student.GroupNumber
                      select student;

         foreach (var item in result)
         {
            Console.WriteLine(item);
         }
      }
      //StringExtension
      public static string LongestWord(this string[] words)
      {
         var result = from word in words
                      orderby word.Length
                      select word;

         return result.ToArray()[result.Count()-1];
      }
   }
}
