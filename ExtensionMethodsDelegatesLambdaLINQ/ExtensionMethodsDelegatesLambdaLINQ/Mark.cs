namespace ExtensionMethodsDelegatesLambdaLINQ
{
   class Mark
   {
      public int Note { get; set; }
      public string Subject { get; set; }

      public Mark(string subject,int note)
      {
         this.Subject = subject;
         this.Note = note;
      }
   }
}
