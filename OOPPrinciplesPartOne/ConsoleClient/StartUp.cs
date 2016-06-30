namespace ConsoleClient
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using StudentsAndWorkers.Models.Humans;
   using StudentsAndWorkers.Infrastructure.Utils;
   using StudentsAndWorkers.Models.Abstract;
   using AnimalHierarchy.Models.Animals;
   using AnimalHierarchy.Models.Abstract;
   class StartUp
   {
      static void Main(string[] args)
      {
         //Problem 2: StudentsAndWorkers
         Random rng = new Random();
         List<Student> students = new List<Student>();
         List<Worker> workers = new List<Worker>();

         for (int i = 0; i < 10; i++)
         {
            students.Add(new Student(NameGenerator.FirstName(rng), NameGenerator.LastName(rng), rng.Next(2, 6)));
            workers.Add(new Worker(NameGenerator.FirstName(rng), NameGenerator.LastName(rng), (decimal)(rng.NextDouble() * 1000), rng.Next(4, 8)));
         }

         //sorting students by grade 
         var sortedStudents = from x in students
                              orderby x.Grade
                              select x;
         //sorting workers by money per hour
         var sortedWorkers = from x in workers
                             orderby x.MoneyPerHour()
                             select x;

         //merging into single list and sorting by first then last name
         var merged = new List<Human>(sortedStudents).Union(sortedWorkers).ToList();

         var sortedHumans = merged.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

         foreach (var item in sortedHumans)
         {
            Console.WriteLine(item);
         }

         Console.WriteLine("===================================================================");

         //Problem3: Animal hierarchy
         Dog[] dogs =
         {
            new Dog("Scooby-Doo", "male", 47),
            new Dog("Beuty", "female", 6)
         };
         Kitten[] kittens =
         {
            new Kitten("Grumpy Cat", 4)
         };
         Tomcat[] tomcats =
         {
            new Tomcat("Tom", 3)
         };
         Frog[] frogs =
         {
            new Frog("Kermit", "male", 61)
         };

         Console.WriteLine("Dogs avg age: {0:F2}", dogs.Sum(x => x.Age)/(double)dogs.Length);
         Console.WriteLine("Kittens avg age: {0:F2}", kittens.Sum(x => x.Age)/(double)kittens.Length);
         Console.WriteLine("Tomcats avg age: {0:F2}", tomcats.Sum(x => x.Age)/(double)tomcats.Length);
         Console.WriteLine("Frogs avg age: {0:F2}", frogs.Sum(x => x.Age)/(double)frogs.Length);
      }
   }
}
