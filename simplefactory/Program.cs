using System;

namespace simplefactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISavingsAccountFactory savingsAccountFactory = new SavingsAccountFactory();
            ISavingsAccount savingsAccount=savingsAccountFactory.GetSavingsAccount("CITY0001");
            Console.WriteLine(savingsAccount.TaxRate); ;
        }
    }

}
