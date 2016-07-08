namespace Cosmetics.Products
{
   using Common;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class Category: ICategory
   {
      private const int CategoryMinLength = 2;
      private const int CategoryMaxLength = 15;
      private string name;
      private ICollection<IProduct> productsList;

      public Category(string name)
      {
         this.Name = name;
         this.ProductsList = new List<IProduct>();
      }

      public string Name
      {
         get
         {
            return this.name;
         }
         private set
         {
            Validator.CheckIfStringLengthIsValid(
               value,
               CategoryMaxLength,
               CategoryMinLength,
               String.Format(GlobalErrorMessages.InvalidStringLength,
               this.GetType().Name + " name", CategoryMinLength, CategoryMaxLength));
            this.name = value;
         }
      }

      public ICollection<IProduct> ProductsList
      {
         get
         {
            return this.productsList;
         }
         private set
         {
            this.productsList = value.OrderBy(x => x.Brand).ThenByDescending(x => x.Price).ToList() as ICollection<IProduct>;
         }
      }

      public void AddCosmetics(IProduct product)
      {
         this.ProductsList.Add(product);
         //needs to be improved
         this.ProductsList = this.ProductsList.OrderBy(x => x.Brand).ThenByDescending(x => x.Price).ToList() as ICollection<IProduct>;
      }

      public void RemoveCosmetics(IProduct product)
      {
         if (this.ProductsList.Contains(product))
         {
            this.ProductsList.Remove(product);
         }
         else
         {
            Console.WriteLine($"Product {product.Name} does not exist in category {this.Name}!");
         }
      }

      public string Print()
      {
         StringBuilder builder = new StringBuilder();

         string productsCount = string.Empty;

         if (this.ProductsList.Count > 1)
         {
            productsCount = "products";
         }else
         {
            productsCount = "product";
         }
         builder.AppendLine($"{this.Name} category – { this.ProductsList.Count} {productsCount} in total");
         foreach (var item in this.ProductsList)
         {
            builder.AppendLine(item.Print());
         }

         return builder.ToString();
      }
   }
}
