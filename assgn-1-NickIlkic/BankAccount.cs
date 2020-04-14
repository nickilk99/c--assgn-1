using System;
using System.Collections.Generic;
using System.Text;

namespace assgn_1_NickIlkic
{
    struct BankAccount
    {
        public float DepositAmount { get; set; }
        public TypeOfAccount TypeOfAccount { get; set; }

        public BankAccount(TypeOfAccount typeOfAccount, float depositAmount)
        {
            TypeOfAccount = typeOfAccount;
            DepositAmount = depositAmount;
        }


    }
}
