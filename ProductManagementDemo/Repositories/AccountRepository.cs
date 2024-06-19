﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_;
using DataAccessObjects;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountID) 
            => AccountDAO.GetAccountById(accountID);
    }
}
