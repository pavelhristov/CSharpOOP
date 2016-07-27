namespace Cosmetics.Products.Abstract
{
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Common;

   public abstract class AProduct : IProduct
   {
      private decimal price;
      private string name;
      private string brand;
      private GenderType gender;
      private const int NameMinLength = 3;
      private const int NameMaxLength = 10;
      private const int BrandMinLength = 2;
      private const int BrandMaxLength = 10;

      public AProduct(string name, string brand, decimal price, GenderType gender)
      {
         this.Name = name;
         this.Brand = brand;
         this.Price = price;
         this.Gender = gender;

      }

      public string Name
      {
         get
         {
            return this.name;
         }
         set
         {
            Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
            Validator.CheckIfStringLengthIsValid(
                 value,
                 NameMaxLength,
                 NameMinLength,
                 String.Format(GlobalErrorMessages.InvalidStringLength,"Product name", NameMinLength, NameMaxLength));
            this.name = value;
         }
      }

      public string Brand
      {
         get
         {
            return this.brand;
         }
         protected set
         {
            Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
            Validator.CheckIfStringLengthIsValid(
                 value,
                 BrandMaxLength,
                 BrandMinLength,
                 String.Format(GlobalErrorMessages.InvalidStringLength,"Product brand", BrandMinLength, BrandMaxLength));
            this.brand = value;
         }
      }

      public decimal Price
      {
         get
         {
            return this.price;
         }
         protected set
         {
            Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
            this.price = value;
         }
      }

      public GenderType Gender
      {
         get
         {
            return this.gender;
         }
         private set
         {
            this.gender = value;
         }
      }

      public virtual string Print()
      {
         StringBuilder builder = new StringBuilder();


         builder.AppendLine($"\r\n- { this.Brand} – { this.Name}:");
         builder.AppendLine($"  * Price: ${ this.Price}");
         builder.Append($"  * For gender: {this.Gender}");

         return builder.ToString();
      }
   }
}
