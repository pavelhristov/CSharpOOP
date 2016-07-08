namespace Core.Models
{
   using Infrastructure.Enumerations;
   using System;
   using System.Collections.Generic;
   using System.IO;
   using System.Linq;
   using System.Runtime.Serialization.Formatters.Binary;
   using System.Text;
   using System.Threading.Tasks;

   public class Student : ICloneable, IComparable<Student>
   {
      private string firstName;
      private string middleName;
      private string lastName;
      private int ssn;
      private string permanentAddress;
      private int mobilePhone;
      private string eMail;
      private int course;
      private SpecialtyType specialty;
      private UniversityType university;
      private FacultyType faculty;


      public Student(string firstName,
                     string middleName,
                     string lastName,
                     int ssn,
                     string permanentAddress,
                     int mobilePhone,
                     string eMail,
                     int course,
                     SpecialtyType specialty,
                     UniversityType university,
                     FacultyType faculty)
      {
         this.FirstName = firstName;
         this.MiddleName = middleName;
         this.LastName = lastName;
         this.SSN = ssn;
         this.PermanentAddress = permanentAddress;
         this.MobilePhone = mobilePhone;
         this.EMail = eMail;
         this.Course = course;
         this.Specialty = specialty;
         this.University = university;
         this.Faculty = faculty;
      }

      public string FirstName
      {
         get
         {
            return this.firstName;
         }
         private set
         {
            this.firstName = value;
         }
      }
      public string MiddleName
      {
         get
         {
            return this.middleName;
         }
         private set
         {
            this.middleName = value;
         }
      }
      public string LastName
      {
         get
         {
            return this.lastName;
         }
         private set
         {
            this.lastName = value;
         }
      }
      public int SSN
      {
         get
         {
            return this.ssn;
         }
         private set
         {
            this.ssn = value;
         }
      }
      public string PermanentAddress
      {
         get
         {
            return this.permanentAddress;
         }
         private set
         {
            this.permanentAddress = value;
         }
      }
      public int MobilePhone
      {
         get
         {
            return this.mobilePhone;
         }
         private set
         {
            this.mobilePhone = value;
         }
      }
      public string EMail
      {
         get
         {
            return this.eMail;
         }
         private set
         {
            this.eMail = value;
         }
      }
      public int Course
      {
         get
         {
            return this.course;
         }
         private set
         {
            this.course = value;
         }
      }
      public SpecialtyType Specialty
      {
         get
         {
            return this.specialty;
         }
         private set
         {
            this.specialty = value;
         }
      }
      public UniversityType University
      {
         get
         {
            return this.university;
         }
         private set
         {
            this.university = value;
         }
      }
      public FacultyType Faculty
      {
         get
         {
            return this.faculty;
         }
         private set
         {
            this.faculty = value;
         }
      }


      public override bool Equals(object obj)
      {
         var student = obj as Student;
         if (this.FirstName == student.FirstName &&
            this.MiddleName == student.MiddleName &&
            this.LastName == student.LastName &&
            this.SSN == student.SSN)
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      public override int GetHashCode()
      {
         return this.SSN.GetHashCode();
      }

      public override string ToString()
      {
         return $"{this.FirstName} {this.MiddleName} {this.LastName} \r\n { this.PermanentAddress} {this.SSN} {this.MobilePhone} {this.EMail} \r\n {this.University} {this.Faculty} {this.Specialty} {this.Course}";
      }

      public object Clone()
      {
         using (var ms = new MemoryStream())
         {
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;

            return (Student)formatter.Deserialize(ms);
         }
      }

      public int CompareTo(Student other)
      {
         int result = 0;

         if (this.FirstName.CompareTo(other.FirstName) > 0)
         {
            result = 1;
         }
         else if (this.FirstName.CompareTo(other.FirstName) < 0)
         {
            result = -1;
         }
         else if (this.SSN > other.SSN)
         {
            result = 1;
         }
         else if (this.SSN < other.SSN)
         {
            result = -1;
         }

         return result;
      }

      public static bool operator ==(Student x, Student y)
      {
         return x.SSN == y.SSN;
      }

      public static bool operator !=(Student x, Student y)
      {
         return !(x.SSN == y.SSN);
      }
   }
}
