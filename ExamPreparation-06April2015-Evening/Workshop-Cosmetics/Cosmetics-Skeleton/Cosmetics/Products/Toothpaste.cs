namespace Cosmetics.Products
{
   using Abstract;
   using Common;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Toothpaste : AProduct, IToothpaste, IProduct
   {
      private string ingredients;
      private const int ingredientsMaxLength = 12;
      private const int ingredientsMinLength = 4;

      public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
         : base(name, brand, price, gender)
      {
         this.Ingredients = string.Join(", ", ingredients);
      }

      public string Ingredients
      {
         get
         {
            return this.ingredients;
         }
         private set
         {
            Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));

            var splited = value.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in splited)
            {
               Validator.CheckIfStringLengthIsValid(
                  item,
                  ingredientsMaxLength,
                  ingredientsMinLength,
                  $"Each ingredient must be between {ingredientsMinLength} and {ingredientsMaxLength} symbols long!");
            }
            this.ingredients = value;
         }
      }

      public override string Print()
      {
         StringBuilder builder = new StringBuilder();

         builder.AppendLine(base.Print());
         builder.Append($"  * Ingredients: {this.Ingredients }");

         return builder.ToString();
      }
   }
}
