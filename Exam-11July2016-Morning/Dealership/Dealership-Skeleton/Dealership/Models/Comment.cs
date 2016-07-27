namespace Dealership.Models
{
   using Common;
   using Contracts;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public class Comment : IComment
   {
      public Comment(string content)
      {
         this.Content = content;
      }

      private string content;

      public string Author { get; set; }

      public string Content
      {
         get
         {
            return this.content;
         }
         private set
         {
            Validator.ValidateIntRange(value.Length,
               Constants.MinCommentLength,
               Constants.MaxCommentLength,
               string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
            this.content = value;
         }
      }
      public override string ToString()
      {
         StringBuilder result = new StringBuilder();
         result.AppendLine(string.Format("    {0}",this.Content));
         result.AppendLine(string.Format("      User: {0}",this.Author));
         return result.ToString();
      }
   }
}
