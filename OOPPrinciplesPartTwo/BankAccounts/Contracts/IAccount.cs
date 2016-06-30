namespace BankAccounts.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;


   public interface IAccount
   {
      ICustomer Customer { get; }
      decimal Balance { get; }
      decimal InterestRate { get; }
   }
}
