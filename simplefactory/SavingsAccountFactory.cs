using System;

namespace simplefactory
{
    public class SavingsAccountFactory : ISavingsAccountFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITY"))
            {
                return new CitySavingsAccount();
            }
            else if (acctNo.Contains("NATIONAL"))
            {
                return new CountrySavingsAccount();
            }
            else
                throw new ArgumentException("Invalid Account Number");
        
        }
    }

}
