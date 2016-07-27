namespace Dealership.Models
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Common.Enums;
   using Common;

   public class User : IUser
   {
      private string firstName;
      private string lastName;
      private string userName;
      private string password;
      private IList<IVehicle> vehicles;

      public User(string username, string firstName, string lastName, string password, string role)
      {
         this.Username = username;
         this.FirstName = firstName;
         this.LastName = lastName;
         this.Password = password;
         this.Role = (Role)Enum.Parse(typeof(Role), role, true);
         this.Vehicles = new List<IVehicle>();
      }

      public string FirstName
      {
         get
         {
            return this.firstName;
         }
         private set
         {
            Validator.ValidateIntRange(value.Length,
               Constants.MinNameLength,
               Constants.MaxNameLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
            this.firstName = value;
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
            Validator.ValidateIntRange(value.Length,
               Constants.MinNameLength,
               Constants.MaxNameLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
            this.lastName = value;
         }
      }

      public string Password
      {
         get
         {
            return this.password;
         }
         private set
         {
            Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
            Validator.ValidateIntRange(value.Length,
               Constants.MinPasswordLength,
               Constants.MaxPasswordLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
            this.password = value;
         }
      }

      public Role Role { get; private set; }

      public string Username
      {
         get
         {
            return this.userName;
         }
         private set
         {
            Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
            Validator.ValidateIntRange(value.Length,
               Constants.MinNameLength,
               Constants.MaxNameLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
            this.userName = value;
         }
      }

      public IList<IVehicle> Vehicles
      {
         get
         {
            return  this.vehicles;
         }
         private set
         {
            this.vehicles = value;
         }
      }

      public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
      {
         Validator.ValidateNull(vehicleToAddComment, Constants.VehicleCannotBeNull);
         Validator.ValidateNull(commentToAdd, Constants.CommentCannotBeNull);
         vehicleToAddComment.Comments.Add(commentToAdd);
      }

      public void AddVehicle(IVehicle vehicle)
      {
         Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
         if (this.Role == Role.Admin)
         {
            throw new Exception(Constants.AdminCannotAddVehicles);
         }
         else if (this.Role == Role.Normal && this.Vehicles.Count > 4)
         {
            throw new Exception(string.Format(Constants.NotAnVipUserVehiclesAdd,5));
         }
         else
         {
            this.Vehicles.Add(vehicle);
         }
      }

      public string PrintVehicles()
      {
         StringBuilder builder = new StringBuilder();
         builder.AppendLine(string.Format("--USER {0}--",this.Username));
         if (Vehicles.Count>0)
         {
            for (int i = 0; i < Vehicles.Count; i++)
            {
               builder.Append(string.Format("{0}. ",i + 1) + Vehicles[i].ToString());
            }
         }else
         {
            builder.AppendLine("--NO VEHICLES--");
         }

         return builder.ToString().Substring(0,builder.Length-2);
      }

      public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
      {
         Validator.ValidateNull(vehicleToRemoveComment, Constants.VehicleCannotBeNull);
         Validator.ValidateNull(commentToRemove, Constants.CommentCannotBeNull);
         if (vehicleToRemoveComment.Comments.Contains(commentToRemove) && commentToRemove.Author == this.Username)
         {
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
         }
         else
         {
            throw new Exception(Constants.YouAreNotTheAuthor);
         }
      }

      public void RemoveVehicle(IVehicle vehicle)
      {
         Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
         if (this.Vehicles.Contains(vehicle))
         {
            this.Vehicles.Remove(vehicle);
         }
      }

      public override string ToString()
      {
         string result = string.Format("Username: {0}, FullName: {1} {2}, Role: {3}",this.Username,this.FirstName,this.LastName,this.Role);
         return result;
      }
   }
}
