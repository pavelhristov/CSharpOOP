namespace GlobulStavaTelenor
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   class Display
   {
      private string size;
      private int colors;

      public Display()
      {
         this.size = "640 x 960";
         this.colors = 256000;
      }

      public Display(string size)
      {
         this.size = size;
      }

      public Display(string size, int colors)
      {
         this.size = size;
         this.colors = colors;
      }
      public string Size
      {
         get
         {
            return this.size;
         }
      }
      public int Colors
      {
         get
         {
            return this.colors;
         }
      }
      public override string ToString()
      {
         return "Display: " + Size + " " + Colors;
      }
   }
}
