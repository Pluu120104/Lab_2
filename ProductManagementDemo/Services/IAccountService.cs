using BusinessObjects_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountByID(string accountID);
    }
}
