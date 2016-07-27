﻿namespace Cosmetics.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public interface IShoppingCart
   {
      ICollection<IProduct> ProductList { get; }

      void AddProduct(IProduct product);

      void RemoveProduct(IProduct product);

      bool ContainsProduct(IProduct product);

      decimal TotalPrice();
   }
}
