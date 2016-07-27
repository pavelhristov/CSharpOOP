namespace Cosmetics.Cart
{
   using Cosmetics.Common;
   using Cosmetics.Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public class ShoppingCart : IShoppingCart
   {
      private ICollection<IProduct> productList;

      public ShoppingCart()
      {
         this.ProductList = null;
      }

      public ICollection<IProduct> ProductList
      {
         get { return new List<IProduct>(productList); }
         set { this.productList = value; }
      }

      public void AddProduct(IProduct product)
      {
         Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "product"));
         this.ProductList.Add(product);
      }

      public void RemoveProduct(IProduct product)
      {
         Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "product"));
         this.ProductList.Remove(product);
      }

      public bool ContainsProduct(IProduct product)
      {
         foreach (IProduct prod in this.productList)
         {
            if (prod.Equals(product))
            {
               return true;
            }
         }

         return false;
      }

      public decimal TotalPrice()
      {
         return (from x in this.ProductList
                 select x.Price).Sum();
      }
   }
}
