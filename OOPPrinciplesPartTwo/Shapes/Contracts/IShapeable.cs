namespace Shapes.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   interface IShapeable
   {
      double Height { get; }
      double Width { get; }
      double CalculateSurface();
   }
}
