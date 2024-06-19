using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(string accountID);
    }
}
