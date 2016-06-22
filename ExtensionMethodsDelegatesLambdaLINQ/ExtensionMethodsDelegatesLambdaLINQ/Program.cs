namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System;
   using System.Collections.Generic;


   class Program
   {
      static void Main(string[] args)
      {
         //sorcery
         //StringBuilder builder = new StringBuilder("Priklucheniqta na Pesho!");
         //StringBuilder subStringBuilder = builder.SubString(15, 8);
         //Console.WriteLine(subStringBuilder.ToString());

         //List<int> numbers = new List<int>()
         //{
         //   1,2,3,4,5,6,7,8,9,0,21,63
         //};

         //var sum = numbers.ExtensionSum();
         //var min = numbers.ExtensionMin();
         //var max = numbers.ExtensionMax();
         //var avarage = numbers.ExtensionAverage();
         //var product = numbers.ExtensionProduct();
         //Console.WriteLine($"{sum} {product} {min} {max} {avarage}");

         //Student[] students = new Student[]
         //{
         //   new Student("Pesho","Ivanov",5),
         //   new Student("Pesho","Welchev",18),
         //   new Student("Pesho","Pesho",24),
         //   new Student("Pesho","Atanasov",20),
         //};

         //Console.WriteLine(StudentMethods.FirstBeforeLast(students));

         //StudentMethods.AgeRange(students);

         //var sorted =StudentMethods.Sort(students);
         //foreach (var item in sorted)
         //{
         //   Console.WriteLine(item);
         //}
         //Console.WriteLine("=============================");
         //var sortedLINQ = StudentMethods.SortLINQ(students);
         //foreach (var item in sortedLINQ)
         //{
         //   Console.WriteLine(item);
         //}

         //Methods.DivisionBySevenAndThreeLINQ(numbers.ToArray());
         //Methods.DivisionBySevenAndThree(numbers.ToArray());

         //Action action = () => Console.WriteLine("TimeElapsed");
         //Timer.ExecuteEachTime(action, 5);


         List<Mark> marks = new List<Mark>()
         {
            //new Mark("Mathematics",6),
            new Mark("English",2),
            new Mark("Deutch",2),
            new Mark("Physics",5)
         };
         Student[] students = new Student[]
         {
            new Student("Pesho","Ivanov",5,"214505","0289123","pesho@pesho.bg",marks,2),
            new Student("Pesho","Welchev",18,"214506","0889124","Superpesho@pesho.bg",marks,1),
            new Student("Pesho","Pesho",24,"214503","0889125","ne_e_pesho@pesho.bg",marks,1),
            new Student("Pesho","Atanasov",20,"214506","0889126","nqkakyv_pesho@abv.bg",new List<Mark> {new Mark("Mathematics",6) },2),
         };

         //var groupTwo = StudentGroups.GroupTwo(students);
         //foreach (var item in groupTwo)
         //{
         //   Console.WriteLine(item);
         //}

         //var abvMails = StudentGroups.ABVEmails(students);
         //foreach (var item in abvMails)
         //{
         //   Console.WriteLine(item);
         //}

         //var byPhones = StudentGroups.ByPhones(students);
         //foreach (var item in byPhones)
         //{
         //   Console.WriteLine(item);
         //}

         //int count = 0;
         //foreach (var item in students)
         //{
         //   if (item.HasTwo2())
         //   {
         //      count++;
         //   } 
         //}
         //Console.WriteLine(count);

         //string[] words = new string[3]
         //{
         //   "adsfasd",
         //   "arhrwierhwieh",
         //   "wer"
         //};

         //Console.WriteLine(words.LongestWord());

         //students.GroupedByGroupNumber();

         StudentMethods.ExelentStudents(students);
      }
   }
}
