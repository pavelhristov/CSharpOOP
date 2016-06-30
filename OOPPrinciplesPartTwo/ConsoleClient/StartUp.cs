namespace ConsoleClient
{
   using BankAccounts.Models;
   using BankAccounts.Models.Abstract;
   using BankAccounts.Models.Accounts;
   using BankAccounts.Models.Customers;
   using Shapes.Models;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using RangeExceptions.Exceptions;
   using RangeExceptions.Validation;

   class StartUp
   {
      static void Main(string[] args)
      {
         //Problem1. Shapes
         //witchcraft

         //double a = int.Parse(Console.ReadLine());
         //double b = int.Parse(Console.ReadLine());

         //Triangle trianlge = new Triangle(a, b);
         //Rectangle rectangle = new Rectangle(a, b);
         //Square square1 = new Square(a, b);
         //Square square2 = new Square(a, a);

         //Console.WriteLine(trianlge.CalculateSurface());
         //Console.WriteLine(rectangle.CalculateSurface());
         //Console.WriteLine(square1.CalculateSurface());
         //Console.WriteLine(square2.CalculateSurface());


         //Problem2. Bank accounts
         //voodoo

         //List<Account> accounts = new List<Account>()
         //{
         //   new Loan(new Company("Pesho and Co"),12,1500,0.2m),
         //   new Mortgage(new Individual("Pesho", "Peshev"),10,1000,0.1m),
         //   new Deposit(new Individual("Pesho000","Peshovski"),24,500,0.5m)
         //};

         //Bank bank = new Bank(accounts);


         //Problem3. Range Exception
         //wicked magic

         //const int rangeStart = 0;
         //const int rangeEnd = 100;

         //DateTime dateRangeStart = Convert.ToDateTime("1.1.1980");
         //DateTime dateRangeEnd = Convert.ToDateTime("31.12.2013");

         //int n = int.Parse(Console.ReadLine());
         //Validator<int>.RangeCheck(n, rangeStart, rangeEnd);

         //DateTime date = DateTime.Now;

         //Validator<DateTime>.RangeCheck(date,dateRangeStart, dateRangeEnd);
         //Validator<DateTime>.RangeCheck(date, dateRangeStart, Convert.ToDateTime("31.12.2017"));
      }
   }
}
