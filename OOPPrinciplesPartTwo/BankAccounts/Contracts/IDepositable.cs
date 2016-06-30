﻿namespace BankAccounts.Contracts
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;

   public interface IDepositable:IAccount
   {
      void Deposit(decimal depositMoney);
   }
}