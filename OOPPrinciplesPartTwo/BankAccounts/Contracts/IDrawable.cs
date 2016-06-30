using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Contracts
{
   public interface IDrawable: IAccount
   {
      void Draw(decimal drawMoney);
   }
}
