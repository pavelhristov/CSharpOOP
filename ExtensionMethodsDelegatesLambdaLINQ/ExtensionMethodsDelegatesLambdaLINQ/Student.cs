﻿namespace ExtensionMethodsDelegatesLambdaLINQ
{
   using System.Collections.Generic;


   class Student
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int Age { get; set; }
      public string FN { get; set; }
      public string Tel { get; set; }
      public string Email { get; set; }
      public List<Mark> Marks { get; set; }
      public int GroupNumber { get; set; }

      public Student()
      {

      }

      public Student(string firstName, string lastName, int age) : this()
      {
         this.FirstName = firstName;
         this.LastName = lastName;
         this.Age = age;
      }

      public Student(string firstName, string lastName, int age, string fn, string tel, string email, List<Mark> marks, int groupNumber) : this(firstName, lastName, age)
      {
         this.FN = fn;
         this.Tel = tel;
         this.Email = email;
         this.Marks = marks;
         this.GroupNumber = groupNumber;
      }

      public override string ToString()
      {
         return $"{FirstName} {LastName} {Age} {FN} {Tel} {Email} {GroupNumber}";
      }
   }
}
